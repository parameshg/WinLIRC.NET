using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinLIRC.Messages.Transmitter;
using WinLIRC.Messages;

namespace WinLIRC.Test
{
    /// <summary>
    /// Tests for verifying WinLIRC.NET signal transmitter and receiver
    /// </summary>
    [TestClass]
    public class TransmitterTest
    {
        /// <summary>
        /// Instance of WinLIRC.NET signal transmitter
        /// </summary>
        private SignalTransmitter _transmitter = null;

        /// <summary>
        /// Initializes WinLIRC.NET transmitter tests
        /// </summary>
        public TransmitterTest()
        {
            _transmitter = new SignalTransmitter();
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
        /// Sends ArrowUp WinLIRC.NET signal
        /// </summary>
        [TestMethod]
        public void SendSingleSignal()
        {
            _transmitter.Send(new Signal(RemoteKey.ArrowUp, string.Empty, string.Empty, string.Empty, 0));
        }

        /// <summary>
        /// Sends a random WinLIRC.NET signal
        /// </summary>
        [TestMethod]
        public void SendSingleRandomSignal()
        {
            _transmitter.Send(new Signal((RemoteKey)new Random().Next(25), 
                string.Empty, string.Empty, string.Empty, 0));
        }

        /// <summary>
        /// Sends 25 random WinLIRC.NET signals
        /// </summary>
        [TestMethod]
        public void SendMultipleRandomSignal()
        {
            for (int i = 1; i <= 25; i++)
            {
                _transmitter.Send(new Signal((RemoteKey)new Random().Next(25),
                    string.Empty, string.Empty, string.Empty, 0));
            }
        }

        /// <summary>
        /// Sends Menu, Select, Cancel WinLIRC.NET signals in an interval of 1 second
        /// </summary>
        [TestMethod]
        public void SendMenuSignal()
        {
            _transmitter.Send(new Signal(RemoteKey.Menu, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Select, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Cancel, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));
        }

        /// <summary>
        /// Sends Play, Pause, Stop, Record, Mute WinLIRC.NET signals in an interval of 1 second
        /// </summary>
        [TestMethod]
        public void SendPlaySignal()
        {
            _transmitter.Send(new Signal(RemoteKey.Play, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Pause, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Stop, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Record, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Mute, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));
        }

        /// <summary>
        /// Sends ArrowUp, ArrowDown, ArrowLeft, ArrowRight, ChannelUp, ChannelDown, VolumeUp and VolumeDown WinLIRC.NET signals in an interval of 1 second
        /// </summary>
        [TestMethod]
        public void SendArrowSignal()
        {
            _transmitter.Send(new Signal(RemoteKey.ArrowUp, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.ArrowDown, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.ArrowLeft, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.ArrowRight, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.ChannelUp, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.ChannelDown, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.VolumeUp, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.VolumeDown, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));
        }

        /// <summary>
        /// Sends Number 0-9 WinLIRC.NET signals in an interval of 1 second
        /// </summary>
        [TestMethod]
        public void SendNumberSignal()
        {
            _transmitter.Send(new Signal(RemoteKey.Number1, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number2, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number3, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number4, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number5, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number6, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number7, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number8, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number9, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));

            _transmitter.Send(new Signal(RemoteKey.Number0, string.Empty, string.Empty, string.Empty, 0));
            Thread.Sleep(new TimeSpan(0, 0, 1));
        }
    }
}