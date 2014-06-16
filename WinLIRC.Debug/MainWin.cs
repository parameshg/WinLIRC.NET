using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinLIRC.Debug
{
    public partial class MainWin : Form
    {
        private Transmitter _transmitter = null;

        private Receiver _receiver = null;

        private Looper _looper = null;

        public MainWin()
        {
            InitializeComponent();

            Menu = GenerateMainMenu();
        }

        private MainMenu GenerateMainMenu()
        {
            MainMenu result = new MainMenu();

            MenuItem mExit = new MenuItem("Exit");
            mExit.Click += new EventHandler(OnExit);

            MenuItem mFile = new MenuItem("File");
            mFile.MenuItems.Add(mExit);

            MenuItem mTranmitter = new MenuItem("Transmitter");
            mTranmitter.Click += new EventHandler(OpenTransmitter);

            MenuItem mReceiver = new MenuItem("Receiver");
            mReceiver.Click += new EventHandler(OpenRecevier);

            MenuItem mLooper = new MenuItem("Looper");
            mLooper.Click += new EventHandler(OpenLooper);

            MenuItem mTools = new MenuItem("Tools");
            mTools.MenuItems.Add(mTranmitter);
            mTools.MenuItems.Add(mReceiver);
            mTools.MenuItems.Add(mLooper);

            MenuItem mAbout = new MenuItem("About");
            mAbout.Enabled = false;

            MenuItem mViewHelp = new MenuItem("ViewHelp");
            mViewHelp.Enabled = false;

            MenuItem mHelp = new MenuItem("Help");
            mHelp.MenuItems.Add(mAbout);
            mHelp.MenuItems.Add(mViewHelp);

            result.MenuItems.Add(mFile);
            result.MenuItems.Add(mTools);
            result.MenuItems.Add(mHelp);

            return result;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenTransmitter(object sender, EventArgs e)
        {
            if (_transmitter == null)
            {
                _transmitter = new Transmitter();
                _transmitter.MdiParent = this;
            }

            _transmitter.Show();
        }

        private void OpenRecevier(object sender, EventArgs e)
        {
            if (_receiver == null)
            {
                _receiver = new Receiver();
                _receiver.MdiParent = this;
            }

            _receiver.Show();
        }

        private void OpenLooper(object sender, EventArgs e)
        {
            if (_looper == null)
            {
                _looper = new Looper();
                _looper.MdiParent = this;
            }

            _looper.Show();
        }
    }
}
