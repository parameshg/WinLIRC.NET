using System;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace WinLIRC.Configuration.Editor
{
    /// <summary>
    /// Entry-point class for WinLIRC.NET configuration editor
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry-point for WinLIRC.NET configuration editor
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        [STAThread]
        public static void Main()
        {
            AppDomain.CurrentDomain.FirstChanceException += new EventHandler<FirstChanceExceptionEventArgs>(OnFirstChanceException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(OnUnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ConfigurationBuilder());
        }

        /// <summary>
        /// Handler to handle any application unhandled exceptions
        /// </summary>
        /// <param name="sender">Object which encountered any unhandled exception</param>
        /// <param name="e">Event arguements</param>
        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e != null)
                HandleException(e.ExceptionObject as Exception);
        }

        /// <summary>
        /// Handler to handle any application first chance exceptions
        /// </summary>
        /// <param name="sender">Object which encountered first chance exception</param>
        /// <param name="e">Event arguements</param>
        private static void OnFirstChanceException(object sender, FirstChanceExceptionEventArgs e)
        {
            if (e != null)
                HandleException(e.Exception);
        }

        /// <summary>
        /// Handles any exception occurred in the system
        /// </summary>
        /// <param name="e">Exception object</param>
        public static void HandleException(Exception e)
        {
            if (e != null)
                MessageBox.Show(e.Message, typeof(Program).FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}