using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinLIRC.Messages;
using WinLIRC.Messages.Transmitter;
using WinLIRC.Messages.Receiver;

namespace WinLIRC.Test
{
    /// <summary>
    /// Loopback tests for verifying WinLIRC.NET signal transmitter and receiver
    /// </summary>
    [TestClass]
    public class LoopbackTest
    {
        /// <summary>
        /// WinLIRC.NET signal transmitter to send remote key signals
        /// </summary>
        private SignalTransmitter _transmitter = null;

        /// <summary>
        /// WinLIRC.NET signal receiver to receive remote key signals
        /// </summary>
        private SignalReceiver _receiver = null;

        /// <summary>
        /// Remote key sent via transmitter
        /// </summary>
        private RemoteKey _sent = RemoteKey.Unknown;

        /// <summary>
        /// Remote key received via receiver
        /// </summary>
        private RemoteKey _received = RemoteKey.Unknown;

        /// <summary>
        /// Initialized loopback test
        /// </summary>
        public LoopbackTest()
        {
            _transmitter = new SignalTransmitter();
            _receiver = new SignalReceiver();

            _receiver.Message += new EventHandler<SignalReceiverEventArgs>(OnNewMessage);
        }

        /// <summary>
        /// Instance of test context
        /// </summary>
        private TestContext _context;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for the current test run
        ///</summary>
        public TestContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
        
        /// <summary>
        /// Executes loopback test
        /// </summary>
        [TestMethod]
        public void Execute()
        {
            _sent = (RemoteKey)new Random().Next(25);

            _transmitter.Send(new Signal(_sent, string.Empty, string.Empty, string.Empty, 0));

            Thread t = new Thread(new ThreadStart(CheckSignal));
            t.Start();
            t.Join(new TimeSpan(0, 0, 10));

            if (t != null && t.ThreadState == ThreadState.Running)
            {
                t.Abort();

                throw new ApplicationException("Transmitter and receiver signal mismatch!");
            }
        }

        /// <summary>
        /// Checks if the transmitted and the received signals are identical
        /// </summary>
        private void CheckSignal()
        {
            while (_sent != _received)
                Thread.Sleep(500);
        }

        /// <summary>
        /// Siganl receiver message handler
        /// </summary>
        /// <param name="sender">Invoker of the event</param>
        /// <param name="e">Event arguments</param>
        private void OnNewMessage(object sender, SignalReceiverEventArgs e)
        {
            if (e!= null && e.Signal != null)
                _received = e.Signal.RemoteKey;
        }
    }
}
