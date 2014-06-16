using System;
using WinLIRC.NET;
using WinLIRC.Messages;

namespace WinLIRC.Receiver.Daemon
{
    /// <summary>
    /// Arguments for event raised by WinLIRC.NET listener when it recives a signal from WinLIRC server
    /// </summary>
    public class ListenerEventArgs : EventArgs
    {
        /// <summary>
        /// Sigal received by WinLIRC.NET from WinLIRC server
        /// </summary>
        public Signal Signal { get; set; }

        /// <summary>
        /// Initializes empty event arguments
        /// </summary>
        public ListenerEventArgs() { }

        /// <summary>
        /// Initializs event arguments with a signal
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        public ListenerEventArgs(Signal signal)
        {
            try
            {
                Signal = signal;
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Initializs event arguments with a stringified signal
        /// </summary>
        /// <param name="signal">WinLIRC signal</param>
        public ListenerEventArgs(string signal)
        {
            try
            {
                Signal = new Signal(signal);
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Initializs event arguments with a stringified signal
        /// </summary>
        /// <param name="remoteName">WinLIRC remote name</param>
        /// <param name="keyName">WinLIRC remote Key name</param>
        /// <param name="keyCode">WinLIRC remote Key code </param>
        /// <param name="repeatCount">WinLIRC remote key count</param>
        public ListenerEventArgs(string remoteName, string keyName, string keyCode, int repeatCount)
        {
            try
            {
                Signal = new Signal(remoteName, keyName, keyCode, repeatCount);
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
    }
}