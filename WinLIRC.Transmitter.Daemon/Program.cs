using System;
using System.Diagnostics;
using WinLIRC.NET;
using System.ServiceProcess;

namespace WinLIRC.Transmitter.Daemon
{
    /// <summary>
    /// Entry-point class for WinLIRC.NET transmitter
    /// </summary>
    public class Program
    {
        private static TransmitterService _service = null;

        /// <summary>
        /// Entry-point for WinLIRC.NET transmitter daemon
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            try
            {
                Trace.TraceInformation("WinLIRC.Transmitter.Daemon starts. Hello World!");

                _service = new TransmitterService();

                #if DEBUG
                    _service.StartDebug();

                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();

                    _service.StopDebug();
                #else
                    ServiceBase.Run(_service);
                #endif

                Trace.TraceInformation("WinLIRC.Transmitter.Daemon exits. By-bye!!!");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
    }
}