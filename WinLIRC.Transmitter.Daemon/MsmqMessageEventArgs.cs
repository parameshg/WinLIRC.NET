using System;
using WinLIRC.NET;
using WinLIRC.Messages;

namespace WinLIRC.Transmitter.Daemon
{
    /// <summary>
    /// Arguments for event raised by reader when it recives a message from MSMQ
    /// </summary>
    public class MsmqMessageEventArgs : EventArgs
    {
        /// <summary>
        /// Sigal received MSMQ reader
        /// </summary>
        public Signal Signal { get; set; }

        /// <summary>
        /// Initializes empty event arguments
        /// </summary>
        public MsmqMessageEventArgs()
        {
        }

        /// <summary>
        /// Initializs event arguments with a signal
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        public MsmqMessageEventArgs(Signal signal)
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
        public MsmqMessageEventArgs(string signal)
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
        /// <param name="keyName">WinLIRC remote key name</param>
        /// <param name="keyCode">WinLIRC remote key code </param>
        /// <param name="repeatCount">WinLIRC remote key count</param>
        public MsmqMessageEventArgs(string remoteName, string keyName, string keyCode, int repeatCount)
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