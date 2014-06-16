using System;
using WinLIRC.Messages.Transmitter;

namespace WinLIRC.Messages
{
    /// <summary>
    /// WinLIRC.NET signal
    /// </summary>
    [Serializable]
    public class Signal
    {
        /// <summary>
        /// WinLIRC.NET Remote Key
        /// </summary>
        public RemoteKey RemoteKey { get; set; }

        /// <summary>
        /// WinLIRC Remote Name
        /// </summary>
        public string RemoteName { get; set; }

        /// <summary>
        /// WinLIRC Remote Key Name
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// WinLIRC Remote Key Code
        /// </summary>
        public string KeyCode { get; set; }

        /// <summary>
        /// WinLIRC Remote Key Repeat Count
        /// </summary>
        public int RepeatCount { get; set; }

        /// <summary>
        /// Initializes empty WinLIRC.NET signal
        /// </summary>
        public Signal() { }

        /// <summary>
        /// Initializs stringified WinLIRC.NET signal
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        public Signal(string signal)
        {
            try
            {
                string[] args = signal.Split(' ');

                if (args.Length.Equals(4))
                {
                    KeyCode = args[0];
                    KeyName = args[2];
                    RemoteName = args[3];

                    int i = 0;
                    int.TryParse(args[1], out i);

                    RepeatCount = i;
                }

                RemoteKey = RemoteKey.Unknown;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal", e);
            }
        }

        /// <summary>
        /// Initializs stringified WinLIRC.NET signal
        /// </summary>
        /// <param name="remoteName">WinLIRC remote name</param>
        /// <param name="keyName">WinLIRC remote key name</param>
        /// <param name="keyCode">WinLIRC remote key code</param>
        /// <param name="repeatCount">WinLIRC remote key repeat count</param>
        public Signal(string remoteName, string keyName, string keyCode, int repeatCount)
        {
            try
            {
                RemoteKey = RemoteKey.Unknown;
                RemoteName = remoteName;
                KeyName = keyName;
                KeyCode = KeyCode;
                RepeatCount = repeatCount;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal", e);
            }
        }
        
        /// <summary>
        /// Initializs stringified WinLIRC.NET signal
        /// </summary>
        /// <param name="remoteKey">WinLIRC.NET remote rey</param>
        /// <param name="remoteName">WinLIRC remote name</param>
        /// <param name="keyName">WinLIRC remote Key name</param>
        /// <param name="keyCode">WinLIRC remote Key code</param>
        /// <param name="repeatCount">WinLIRC remote repeat count</param>
        public Signal(RemoteKey remoteKey, string remoteName, string keyName, string keyCode, int repeatCount)
        {
            try
            {
                RemoteKey = remoteKey;
                RemoteName = remoteName;
                KeyName = keyName;
                KeyCode = KeyCode;
                RepeatCount = repeatCount;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize a signal", e);
            }
        }

        /// <summary>
        /// Sends WinLIRC.NET sigal to the outbound communication channel
        /// </summary>
        public void Send()
        {
            try
            {
                new SignalTransmitter().Send(this);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot send signal", e);
            }
        }

        /// <summary>
        /// Sends WinLIRC.NET sigal for the Remote Key to the outbound communication channel
        /// </summary>
        /// <param name="remoteKey">WinLIRC.NET remote key</param>
        public static void Send(RemoteKey remoteKey)
        {
            try
            {
                new Signal(remoteKey, string.Empty, string.Empty, string.Empty, 0).Send();
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot send signal", e);
            }
        }

        /// <summary>
        /// Gets stringified version of WinLIRC.NET signal
        /// </summary>
        /// <returns>Stringified version of WinLIRC.NET signal</returns>
        public override string ToString()
        {
            string result = "[Unknown]";

            try
            {
                result = string.Format("RemoteKey={0}|RemoteName={1}|KeyName={2}|KeyCode={3}|RepeatCount={4}",
                    RemoteKey.ToString(), RemoteName, KeyName, KeyCode, RepeatCount);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot format signal", e);
            }

            return result;
        }
    }
}