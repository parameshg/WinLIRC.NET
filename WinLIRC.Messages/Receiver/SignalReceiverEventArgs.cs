using System;
using WinLIRC.Messages;

namespace WinLIRC.Messages.Receiver
{
    /// <summary>
    /// Arguments for event raised by receiver when it receives a WinLIRC.NET signal
    /// </summary>
    public class SignalReceiverEventArgs : EventArgs
    {
        /// <summary>
        /// WinLIRC.NET sigal received
        /// </summary>
        public Signal Signal { get; set; }

        /// <summary>
        /// Initializes empty event arguments
        /// </summary>
        public SignalReceiverEventArgs() { }

        /// <summary>
        /// Initializs event arguments with a signal
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        public SignalReceiverEventArgs(Signal signal)
        {
            try
            {
                Signal = signal;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal receiver event arguments", e);
            }
        }

        /// <summary>
        /// Initializs event arguments with a stringified signal
        /// </summary>
        /// <param name="signal">WinLIRC signal</param>
        public SignalReceiverEventArgs(string signal)
        {
            try
            {
                Signal = new Signal(signal);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal receiver event arguments", e);
            }
        }

        /// <summary>
        /// Initializs event arguments with a stringified signal
        /// </summary>
        /// <param name="remoteName">WinLIRC remote name</param>
        /// <param name="keyName">WinLIRC remote key name</param>
        /// <param name="keyCode">WinLIRC remote key code </param>
        /// <param name="repeatCount">WinLIRC remote key count</param>
        public SignalReceiverEventArgs(string remoteName, string keyName, string keyCode, int repeatCount)
        {
            try
            {
                Signal = new Signal(remoteName, keyName, keyCode, repeatCount);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal receiver event arguments", e);
            }
        }
    }
}