using System;
using System.Configuration;
using System.Messaging;

namespace WinLIRC.Messages.Transmitter
{
    /// <summary>
    /// WinLIRC.NET signal transmitter
    /// </summary>
    public class SignalTransmitter
    {
        private MessageQueue _queue = null;

        /// <summary>
        /// Initializes WinLIRC.NET signal transmitter with a queue
        /// </summary>
        /// <param name="queue"></param>
        public SignalTransmitter(string queue)
        {
            try
            {
                if (string.IsNullOrEmpty(queue))
                    throw new NullReferenceException("Transmitter queue is empty");

                _queue = new MessageQueue(queue);
                _queue.Formatter = new BinaryMessageFormatter();
                _queue.DefaultPropertiesToSend.UseDeadLetterQueue = true;
                _queue.DefaultPropertiesToSend.TimeToBeReceived = new TimeSpan(0, 0, 10);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal transmitter", e);
            }
        }

        /// <summary>
        /// Initializes an empty WinLIRC sigal transmitter
        /// </summary>
        public SignalTransmitter()
        {
            try
            {
                string queue = ConfigurationManager.AppSettings["WinLIRC_TransmitterQueue"];

                if (string.IsNullOrEmpty(queue))
                    throw new NullReferenceException("Transmitter queue configuration is empty");

                _queue = new MessageQueue(queue);
                _queue.Formatter = new BinaryMessageFormatter();
                _queue.DefaultPropertiesToSend.UseDeadLetterQueue = true;
                _queue.DefaultPropertiesToSend.TimeToBeReceived = new TimeSpan(0, 0, 10);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Cannot initialize signal transmitter", e);
            }
        }

        /// <summary>
        /// Sends WinLIRC.NET signal to queue
        /// </summary>
        /// <param name="signal">WinLIRC.NET signal</param>
        public void Send(Signal signal)
        {
            try
            {
                if (signal == null)
                    throw new NullReferenceException("Invalid signal encountered");

                Message msg = new Message(signal, new BinaryMessageFormatter());
                msg.UseDeadLetterQueue = true;
                msg.TimeToBeReceived = new TimeSpan(0, 0, 10);

                _queue.Send(msg);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Transmitter is unable to send signal", e);
            }
        }
    }
}