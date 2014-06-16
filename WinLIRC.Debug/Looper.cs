using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinLIRC.Messages.Receiver;

namespace WinLIRC.Debug
{
    public partial class Looper : Form
    {
        private bool Active { get; set; }

        private EventHandler<SignalReceiverEventArgs> Handler { get; set; }

        public Looper()
        {
            InitializeComponent();

            Active = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            Handler = new EventHandler<SignalReceiverEventArgs>(OnNewMessage);
        }

        private void OnNewMessage(object sender, SignalReceiverEventArgs e)
        {
            if (Active)
                Program.Transmitter.Send(e.Signal);
        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }

        private void OnStart(object sender, EventArgs e)
        {
            Program.Receiver.Message += Handler;

            Active = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void OnStop(object sender, EventArgs e)
        {
            Program.Receiver.Message -= Handler;

            Active = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}