using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Messaging;
using System.Threading;
using WinLIRC.Messages;
using WinLIRC.NET;
using WinLIRC.Transmitter.Daemon.Settings;

namespace WinLIRC.Transmitter.Daemon
{
    /// <summary>
    /// Reader to read MSMQ messages from queues
    /// </summary>
    public class MsmqReader
    {
        /// <summary>
        /// Event raised when the reader encounters a MSMQ message
        /// </summary>
        public event EventHandler<MsmqMessageEventArgs> Message;

        /// <summary>
        /// Switch to enable reader to listner for MSMQ messages
        /// </summary>
        public bool Enabled { get; private set; }

        /// <summary>
        /// MSMQ instance to listen for messages
        /// </summary>
        private List<MessageQueue> _queues = null;

        /// <summary>
        /// Thread hosting core execution for the reader
        /// </summary>
        private List<Thread> _threads = null;

        /// <summary>
        /// Intializes MSMQ reader with a queue
        /// </summary>
        public MsmqReader()
        {
            try
            {
                _queues = new List<MessageQueue>();
                _threads = new List<Thread>();

                foreach (ApplicationSetting setting in TransmitterSettings.Default.Applications)
                {
                    Trace.TraceInformation("Initalizing queue {0}...", setting.Queue);

                    MessageQueue q = new MessageQueue(setting.Queue);
                    q.Formatter = new BinaryMessageFormatter();
                    q.DefaultPropertiesToSend.UseDeadLetterQueue = true;
                    q.DefaultPropertiesToSend.TimeToBeReceived = new TimeSpan(0, 0, 10);

                    Trace.TraceInformation("Queue {0} initalized.", setting.Queue);

                    Trace.TraceInformation("Adding queue {0} to the list of inbound queues...", q.QueueName);

                    _queues.Add(q);
                    _threads.Add(new Thread(new ParameterizedThreadStart(Listen)));

                    Trace.TraceInformation("Queue {0} added to the list of inbound queues.", q.QueueName);
                }
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Starts MSMQ reader
        /// </summary>
        public void Start()
        {
            try
            {
                Enabled = true;

                for (int i = 0; i < _threads.Count; i++)
                    _threads[i].Start(_queues[i]);
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Stops MSMQ reader
        /// </summary>
        public void Stop()
        {
            try
            {
                Enabled = false;

                foreach(Thread t in _threads)
                    t.Join();
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Listens for messages from configured MSMQ
        /// </summary>
        private void Listen(object q)
        {
            try
            {
                while (Enabled) { ReceiveMessage(q as MessageQueue); }
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Retrieves messages from configured MSMQ
        /// </summary>
        private void ReceiveMessage(MessageQueue q)
        {
            try
            {
                if (q != null)
                {
                    Message msg = q.Receive(new TimeSpan(0, 0, 1)); // 1 sec timeout

                    if (msg != null)
                    {
                        msg.Formatter = new BinaryMessageFormatter();

                        if (msg.Body != null)
                        {
                            if (Message != null)
                                Message(this, new MsmqMessageEventArgs((Signal)msg.Body));
                        }
                    }
                }
            }
            catch (MessageQueueException msmqEx)
            {
                if (msmqEx.ErrorCode != -2147467259) // time-out expired exception error code
                    throw;
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
    }
}