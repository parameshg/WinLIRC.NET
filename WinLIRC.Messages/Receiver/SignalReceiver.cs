using System;
using System.Messaging;
using System.Threading;
using System.IO;
using System.Text;
using WinLIRC.Messages;
using System.Configuration;

namespace WinLIRC.Messages.Receiver
{
    /// <summary>
    /// WinLIRC.NET signal receiver
    /// </summary>
    public class SignalReceiver
    {
        /// <summary>
        /// Event raised when the receiver encounters a WinLIRC.NET signal
        /// </summary>
        public event EventHandler<SignalReceiverEventArgs> Message;

        /// <summary>
        /// Switch to enable receiver to receive WinLIRC.NET signal
        /// </summary>
        public bool Listening { get; private set; }

        /// <summary>
        /// Queue instance to listen for WinLIRC.NET signal
        /// </summary>
        private MessageQueue _queue = null;

        /// <summary>
        /// Thread hosting core execution for the receiver
        /// </summary>
        private Thread _thread = null;

        /// <summary>
        /// Initializes WinLIRC.NET signal receiver with a queue
        /// </summary>
        /// <param name="queue"></param>
        public SignalReceiver(string queue)
        {
            try
            {
                if (string.IsNullOrEmpty(queue))
                    throw new NullReferenceException("Receiver queue is empty");

                _queue = new MessageQueue(queue);

                _thread = new Thread(new ThreadStart(Listen));
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal receiver", e);
            }
        }

        /// <summary>
        /// Initializes empty WinLIRC.NET signal receiver
        /// </summary>
        public SignalReceiver()
        {
            try
            {
                string queue = ConfigurationManager.AppSettings["WinLIRC_ReceiverQueue"];

                if (string.IsNullOrEmpty(queue))
                    throw new NullReferenceException("Receiver queue configuration is empty");

                _queue = new MessageQueue(queue);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal receiver", e);
            }
        }

        /// <summary>
        /// Starts WinLIRC.NET signal receiver
        /// </summary>
        public void Start()
        {
            try
            {
                _thread = new Thread(new ThreadStart(Listen));

                _thread.Start();

                Listening = true;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot start signal receiver", e);
            }
        }

        /// <summary>
        /// Stops WinLIRC.NET signal receiver
        /// </summary>
        public void Stop()
        {
            try
            {
                Listening = false;

                _thread.Join();

                _thread = null;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot stop signal receiver", e);
            }
        }

        /// <summary>
        /// Listens for WinLIRC.NET signal
        /// </summary>
        private void Listen()
        {
            try
            {
                while (Listening) { ReceiveMessage(); }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in signal receiver while listening for signal", e);
            }
        }

        /// <summary>
        /// Fetches a WinLIRC signal
        /// </summary>
        private void ReceiveMessage()
        {
            try
            {
                if (_queue != null)
                {
                    Message msg = _queue.Receive(new TimeSpan(0, 0, 1)); // 1 sec timeout

                    if (msg != null)
                    {
                        msg.Formatter = new BinaryMessageFormatter();

                        if (msg.Body != null)
                        {
                            if (Message != null)
                                Message(this, new SignalReceiverEventArgs((Signal)msg.Body));
                        }
                    }
                }
            }
            catch (MessageQueueException msmqEx)
            {
                if (!msmqEx.Message.Contains("Timeout")) // time-out expired exception error code
                    throw;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error in signal receiver while reading from receiver queue", e);
            }
        }
    }
}