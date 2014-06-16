using System;
using System.Collections.Generic;
using System.Messaging;
using System.Diagnostics;
using WinLIRC.NET;
using WinLIRC.Messages;
using WinLIRC.Receiver.Daemon.Settings;

namespace WinLIRC.Receiver.Daemon
{
    /// <summary>
    /// Writer to write MSMQ messages to queues
    /// </summary>
    public class MsmqWriter
    {
        /// <summary>
        /// List of queues to which messages are written
        /// </summary>
        private List<MessageQueue> _queues = null;

        /// <summary>
        /// Initializes MSMQ writer
        /// </summary>
        public MsmqWriter()
        {
            try
            {
                Trace.TraceInformation("Initalizing queue writer...");

                _queues = new List<MessageQueue>();

                foreach (ApplicationSetting setting in ReceiverSettings.Default.Applications)
                {
                    Trace.TraceInformation("Initalizing queue {0}...", setting.Queue);

                    MessageQueue q = new MessageQueue(setting.Queue);
                    q.Formatter = new BinaryMessageFormatter();
                    q.DefaultPropertiesToSend.UseDeadLetterQueue = true;
                    q.DefaultPropertiesToSend.TimeToBeReceived = new TimeSpan(0, 0, 10);

                    Trace.TraceInformation("Queue {0} initalized.", setting.Queue);

                    Trace.TraceInformation("Adding queue {0} to the list of outgoing queues...", q.QueueName);

                    _queues.Add(q);

                    Trace.TraceInformation("Queue {0} added to the list of outgoing queues.", q.QueueName);
                }

                Trace.TraceInformation("Queue writer initalized.");
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }

        /// <summary>
        /// Writes WinLIRC.NET signal to MSMQ
        /// </summary>
        /// <param name="signal">WinLIRC signal</param>
        public void Write(Signal signal)
        {
            try
            {
                Trace.TraceInformation("Initalizing queue message...");
                
                Message msg = new Message(signal, new BinaryMessageFormatter());
                msg.UseDeadLetterQueue = true;
                msg.TimeToBeReceived = new TimeSpan(0, 0, 10);

                Trace.TraceInformation("Queue message ({0}) initalized.", msg.Id);

                Trace.TraceInformation("Writing message {0} to outgoing queues...", msg.Id);

                foreach (MessageQueue q in _queues)
                {
                    Trace.TraceInformation("Sending message {0} to queue {1}...", msg.Id, q.QueueName);

                    q.Send(msg);

                    Trace.TraceInformation("Message {0} sent to queue {1}.", msg.Id, q.QueueName);
                }

                Trace.TraceInformation("Message {0} written to outgoing queues.", msg.Id);
            }
            catch (Exception e)
            {
                e.HandleException();
            }
        }
    }
}