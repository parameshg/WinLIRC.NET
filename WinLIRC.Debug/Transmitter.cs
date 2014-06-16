using System;
using System.Windows.Forms;
using WinLIRC.Messages;

namespace WinLIRC.Debug
{
    public partial class Transmitter : Form
    {
        public Transmitter()
        {
            InitializeComponent();
        }

        private void OnRemoteKeyPress(object sender, EventArgs e)
        {
            try
            {
                Button b = sender as Button;

                if (b != null && b.Tag != null)
                {
                    RemoteKey key = (RemoteKey)Enum.Parse(typeof(RemoteKey), b.Tag.ToString());

                    Program.Transmitter.Send(new Signal(key, string.Empty, string.Empty, string.Empty, 0));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}