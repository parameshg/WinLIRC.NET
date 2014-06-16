using System;
using System.ServiceProcess;
using System.Diagnostics;
using WinLIRC.NET;

namespace WinLIRC.Receiver.Daemon
{
    /// <summary>
    /// WinLIRC listener service
    /// </summary>
    public class ListenerService : ServiceBase
    {
        /// <summary>
        /// WinLIRC listner instance
        /// </summary>
        private Listener _listener = null;

        /// <summary>
        /// MSMQ writer instance
        /// </summary>
        private MsmqWriter _writer = null;

        /// <summary>
        /// Starts WinLIRC listener service
        /// </summary>
        /// <param name="args">Startup Arguments</param>
        protected override void OnStart(string[] args)
        {
            try
            {
                Trace.TraceInformation("Starting service WinLIRC.Receiver.Daemon.ListenerService...");

                _writer = new MsmqWriter();

                _listener = new Listener();
                _listener.Message += new EventHandler<ListenerEventArgs>(OnNewMessage);

                _listener.Start();

                Trace.TraceInformation("Service WinLIRC.Receiver.Daemon.ListenerService started!");
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
                Trace.TraceInformation("Stopping service WinLIRC.Receiver.Daemon.ListenerService...");

                _listener.Stop();

                Trace.TraceInformation("Service WinLIRC.Receiver.Daemon.ListenerService stopped!");
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
                Trace.TraceInformation("Starting service WinLIRC.Receiver.Daemon.ListenerService:Debug...");

                OnStart(null);

                Trace.TraceInformation("Service (Debug) WinLIRC.Receiver.Daemon.ListenerService:Debug started!");
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
                Trace.TraceInformation("Stopping service WinLIRC.Receiver.Daemon.ListenerService:Debug...");

                OnStop();

                Trace.TraceInformation("Service WinLIRC.Receiver.Daemon.ListenerService:Debug stopped!");
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
        private void OnNewMessage(object sender, ListenerEventArgs e)
        {
            try
            {
                if (e != null && e.Signal != null)
                {
                    Trace.TraceInformation(string.Format("Received signal {0}", e.Signal.ToString()));

                    if (_writer != null)
                        _writer.Write(e.Signal);
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