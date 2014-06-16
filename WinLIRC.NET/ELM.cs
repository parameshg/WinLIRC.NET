using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace WinLIRC.NET
{
    /// <summary>
    /// Enterprise Library Manager - A wrapper class for Mirosoft Enterprise Library 5.0
    /// </summary>
    public class ELM
    {
        /// <summary>
        /// Exception policy name configured in Mirosoft Enterprise Library configuration
        /// </summary>
        private const string ERROR_POLICY = "Policy";

        /// <summary>
        /// Default instance field of Enterprise Library Manager
        /// </summary>
        private static ELM _default;

        /// <summary>
        /// Default instance propery of Enterprise Library Manager
        /// </summary>
        public static ELM Default
        {
            get
            {
                if (_default == null)
                    _default = new ELM();

                return _default;
            }
        }

        /// <summary>
        /// Intializes Enterprise Library Manager - Restricts ELM creation using default instance property
        /// </summary>
        private ELM() { }

        /// <summary>
        /// Handles exception according to the application configuration
        /// </summary>
        /// <param name="e">Exception object</param>
        public void HandleException(Exception e)
        {
            try 
            {
                ExceptionPolicy.HandleException(e, ERROR_POLICY);
            }
            catch(Exception err)
            {
                Trace.TraceError(string.Format("Error Squared! Error while handling exception: {0}", err.Message));
            }
        }
    }
}