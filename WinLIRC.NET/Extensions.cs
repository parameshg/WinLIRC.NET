using System;
using System.Diagnostics;

namespace WinLIRC.NET
{
    /// <summary>
    /// Extension methods for the application
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Handles exceptions and routes it to ELM (Enterprise Library Manager)
        /// </summary>
        /// <param name="e">Exception object</param>
        public static void HandleException(this Exception e)
        {
            try
            {
                Trace.TraceError(e.Message);

                ELM.Default.HandleException(e);
            }
            catch (Exception err)
            {
                Trace.TraceError(string.Format("Error Squared! Error while handling exception: {0}", err.Message));
            }
        }
    }
}