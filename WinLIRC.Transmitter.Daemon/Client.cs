using System;
using System.Diagnostics;
using System.IO;
using WinLIRC.NET;
using WinLIRC.Configuration;
using WinLIRC.Messages;
using WinLIRC.Transmitter.Daemon.Settings;

namespace WinLIRC.Transmitter.Daemon
{
    /// <summary>
    /// WinLIRC.NET signal transmitter - Transmits Infra-Red signals to WinLIRC server
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Transmits WinLIRC.NET signal
        /// </summary>
        /// <param name="s">WinLIRC.NET signal</param>
        public void Send(Signal s)
        {
            try
            {
                FindRemote(ref s);

                InvokeExternalProcess(s);
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
        private void FindRemote(ref Signal signal)
        {
            try
            {
                ConfigurationSource file = new ConfigurationSource();

                bool identified = false;

                foreach (irconfig config in file.ReadXml(new FileInfo(TransmitterSettings.Default.RemoteKeys)))
                {
                    foreach (code code in config.remote_codes)
                    {
                        if (((int)signal.RemoteKey) == ((int)code.key))
                        {
                            signal.RemoteName = config.name;
                            signal.KeyCode = code.value;
                            signal.KeyName = code.name;
                            signal.RepeatCount = 0;

                            identified = true;
                            break;
                        }
                    }

                    if (identified)
                        break;
                }
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Invokes external WinLIRC transmitter
        /// </summary>
        /// <param name="s">WinLIRC.NET signal</param>
        private void InvokeExternalProcess(Signal s)
        {
            try
            {
                if (!string.IsNullOrEmpty(s.RemoteName) &&
                    !string.IsNullOrEmpty(s.KeyName) &&
                    !string.IsNullOrEmpty(s.KeyCode))
                {
                    if (File.Exists(TransmitterSettings.Default.Client))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(TransmitterSettings.Default.Client);
                        psi.Arguments = string.Format("{0} {1} {2}", s.RemoteName, s.KeyName, s.RepeatCount);
                        psi.CreateNoWindow = true;

                        Process p = new Process();
                        p.StartInfo = psi;
                        p.Start();
                    }
                }
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
    }
}