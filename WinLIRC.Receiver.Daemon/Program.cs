using System;
using System.Diagnostics;
using WinLIRC.NET;
using System.ServiceProcess;

namespace WinLIRC.Receiver.Daemon
{
    /// <summary>
    /// Entry-point class for WinLIRC.NET receiver
    /// </summary>
    public class Program
    {
        /// <summary>
        /// WinLIRC.NET listener/receiver service
        /// </summary>
        private static ListenerService _service = null;

        /// <summary>
        /// Entry-point for WinLIRC.NET receiver daemon
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            try
            {
                Trace.TraceInformation("WinLIRC.Receiver.Daemon starts. Hello World!");

                _service = new ListenerService();
                
                #if DEBUG
                    _service.StartDebug();

                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();

                    _service.StopDebug();
                #else
                    ServiceBase.Run(_service);
                #endif

                Trace.TraceInformation("WinLIRC.Receiver.Daemon exits. By-bye!!!");
            }
            catch (Exception e)
            {
                e.HandleException();

                Console.WriteLine(e.Message);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}