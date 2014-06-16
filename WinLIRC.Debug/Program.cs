using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinLIRC.Messages.Transmitter;
using WinLIRC.Messages.Receiver;

namespace WinLIRC.Debug
{
    public static class Program
    {
        internal static SignalTransmitter Transmitter { get; set; }

        internal static SignalReceiver Receiver { get; set; }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Transmitter = new SignalTransmitter();
            Receiver = new SignalReceiver();

            Application.Run(new MainWin());
        }
    }
}
