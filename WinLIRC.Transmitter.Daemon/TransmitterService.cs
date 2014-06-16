using System;
using System.ServiceProcess;
using System.Diagnostics;
using WinLIRC.NET;

namespace WinLIRC.Transmitter.Daemon
{
    /// <summary>
    /// WinLIRC listener service
    /// </summary>
    public class TransmitterService : ServiceBase
    {
        /// <summary>
        /// WinLIRC listner instance
        /// </summary>
        private Client _client = null;

        /// <summary>
        /// MSMQ writer instance
        /// </summary>
        private MsmqReader _reader = null;

        /// <summary>
        /// Starts WinLIRC listener service
        /// </summary>
        /// <param name="args">Startup arguments</param>
        protected override void OnStart(string[] args)
        {
            try
            {
                Trace.TraceInformation("Starting service WinLIRC.Transmitter.Daemon.TransmitterService...");

                _client = new Client();

                _reader = new MsmqReader();
                _reader.Message += new EventHandler<MsmqMessageEventArgs>(OnNewMessage);
                _reader.Start();

                Trace.TraceInformation("Service WinLIRC.Transmitter.Daemon.TransmitterService started!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Stops WinLIRC listener service
        /// </summary>
        protected override void OnStop()
        {
            try
            {
                Trace.TraceInformation("Stopping service WinLIRC.Transmitter.Daemon.TransmitterService...");

                _reader.Stop();

                Trace.TraceInformation("Service WinLIRC.Transmitter.Daemon.TransmitterService stopped!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

#if DEBUG
        /// <summary>
        /// Starts WinLIRC listener service in debug mode
        /// </summary>
        public void StartDebug()
        {
            try
            {
                Trace.TraceInformation("Starting service WinLIRC.Transmitter.Daemon.TransmitterService:Debug...");

                OnStart(null);

                Trace.TraceInformation("Service (Debug) WinLIRC.Transmitter.Daemon.TransmitterService:Debug started!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Stops WinLIRC debug-mode listener service
        /// </summary>
        public void StopDebug()
        {
            try
            {
                Trace.TraceInformation("Stopping service WinLIRC.Transmitter.Daemon.TransmitterService:Debug...");

                OnStop();

                Trace.TraceInformation("Service WinLIRC.Transmitter.Daemon.TransmitterService:Debug stopped!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
#endif

        /// <summary>
        /// New message handler for WinLIRC.NET listener 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewMessage(object sender, MsmqMessageEventArgs e)
        {
            try
            {
                if (e != null && e.Signal != null)
                {
                    Trace.TraceInformation(string.Format("Received signal {0}", e.Signal.ToString()));

                    if (_client != null)
                        _client.Send(e.Signal);
                }
                else
                    Trace.TraceWarning("Received unknown signal event");
            }
            catch (Exception err)
            {
                err.HandleException();
            }
        }
    }
}