using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Net.Sockets;
using WinLIRC.NET;
using WinLIRC.Messages;
using WinLIRC.Configuration;
using WinLIRC.Receiver.Daemon.Settings;

namespace WinLIRC.Receiver.Daemon
{
    /// <summary>
    /// WinLIRC.NET signal listener - Listens for Infra-Red signals from WinLIRC server and raises a event for every new signal received
    /// </summary>
    public class Listener
    {
        /// <summary>
        /// Event raised for every Infra-Red signal received from WinLIRC server
        /// </summary>
        public event EventHandler<ListenerEventArgs> Message;

        /// <summary>
        /// Switch to enable listener to listen for Infra-Red signal from WinLIRC server
        /// </summary>
        public bool Enabled { get; private set; }

        /// <summary>
        /// TCP client which connects to WinLIRC server to receive Infra-Red signals
        /// </summary>
        private TcpClient _client = null;

        /// <summary>
        /// Thread hosting the core execution of listener to receive Infra-Red signals from WinLIRC server
        /// </summary>
        private Thread _thread = null;

        /// <summary>
        /// Starts the listener and listens for signals from WinLIRC server
        /// </summary>
        public void Start()
        {
            try
            {
                Trace.TraceInformation("Starting listener WinLIRC.Receiver.Daemon.Listener...");

                Enabled = true;

                _thread = new Thread(new ThreadStart(Execute));
                _thread.Start();

                Trace.TraceInformation("Listener WinLIRC.Receiver.Daemon.Listener started!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Stop the WinLIRC.NET listener
        /// </summary>
        public void Stop()
        {
            try
            {
                Trace.TraceInformation("Stopping listener WinLIRC.Receiver.Daemon.Listener...");

                Enabled = false;

                _thread.Abort();

                Trace.TraceInformation("Listener WinLIRC.Receiver.Daemon.Listener stopped!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Core listening logic of WinLIRC.NET server
        /// </summary>
        private void Execute()
        {
            try
            {
                Trace.TraceInformation("Connecting listener to WinLIRC server...");

                _client = new TcpClient();

                _client.Connect(new IPEndPoint(ReceiverSettings.Default.Server, ReceiverSettings.Default.Port));

                if (_client.Connected)
                {
                    Trace.TraceInformation("Listener is now connected to WinLIRC server.");

                    using (StreamReader reader = new StreamReader(_client.GetStream()))
                    {
                        while (Enabled)
                        {
                            Trace.TraceInformation("Listener waiting for signal from WinLIRC server.");

                            string signal = reader.ReadLine();

                            Trace.TraceInformation("Listener received a signal ({0}) from WinLIRC server.", signal);
#if DEBUG
                            Console.WriteLine(signal);
#endif
                            if (!string.IsNullOrEmpty(signal))
                            {
                                if (Message != null)
                                {
                                    Signal s = new Signal(signal);

                                    if (!string.IsNullOrEmpty(s.RemoteName) &&
                                        !string.IsNullOrEmpty(s.KeyName) &&
                                        !string.IsNullOrEmpty(s.KeyCode))
                                    {
                                        FindRemoteKey(ref s);

                                        Trace.TraceInformation("Raising event for the received signal ({0}).", s.ToString());

                                        Message(this, new ListenerEventArgs(s));
                                    }
                                    else
                                        Trace.TraceWarning("Invalid signal received from WinLIRC server.");
                                }
                            }
                        }
                    }
                }
                else
                    throw new ApplicationException("Listener cannot connect to WinLIRC server");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Decodes incoming Infra-Red signal's remote key into WinLIRC.NET remote key format
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        private void FindRemoteKey(ref Signal signal)
        {
            try
            {
                Trace.TraceInformation("Attempting to detect remote key for signal {0}...", signal.ToString());

                ConfigurationSource file = new ConfigurationSource();

                foreach (irconfig config in file.ReadXml(new FileInfo(ReceiverSettings.Default.RemoteKeys)))
                {
                    if (signal.RemoteName.Equals(config.name))
                    {
                        foreach (code code in config.remote_codes)
                        {
                            if (signal.KeyName.Equals(code.name))
                            {
                                signal.RemoteKey = (RemoteKey)(int)code.key;

                                Trace.TraceInformation("RemoteKey found - {0}.", signal.RemoteKey.ToString());

                                break;
                            }
                        }

                        break;
                    }
                }

                if (signal.RemoteKey == RemoteKey.Unknown)
                    Trace.TraceWarning("Unknown remote key signal received");
            }
            catch(Exception e)
            {
                e.HandleException();
            }
        }
    }
}