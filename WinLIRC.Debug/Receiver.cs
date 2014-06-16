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
    public partial class Receiver : Form
    {
        public Receiver()
        {
            InitializeComponent();

            Program.Receiver.Message += new EventHandler<SignalReceiverEventArgs>(OnNewMessage);

            if (Program.Receiver.Listening)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void OnNewMessage(object sender, SignalReceiverEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new EventHandler<SignalReceiverEventArgs>(OnNewMessage), sender, e);
            else
            {
                if (e != null && e.Signal != null)
                    lvSignals.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), e.Signal.RemoteName, e.Signal.RemoteKey.ToString(), e.Signal.KeyCode, e.Signal.KeyName, e.Signal.RepeatCount.ToString() }));
            }
        }

        private void OnStart(object sender, EventArgs e)
        {
            if (!Program.Receiver.Listening)
            {
                Program.Receiver.Start();

                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void OnStop(object sender, EventArgs e)
        {
            if (Program.Receiver.Listening)
            {
                Program.Receiver.Stop();

                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}