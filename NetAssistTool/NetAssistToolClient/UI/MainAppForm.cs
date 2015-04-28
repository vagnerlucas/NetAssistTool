using NetAssistToolClient.core;
using NetAssistToolClient.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetAssistToolClient.ui
{
    public partial class MainAppForm : Form, IObserver
    {
        Pinger pinger = new Pinger();

        public MainAppForm()
        {
            InitializeComponent();
            pinger.Attach(this);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            pinger.PingTest();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Update(Subject subject)
        {
            if (pinger == subject)
            {
                textBoxClientMsg.Text += pinger.GetMessage(false);
            }
        }
    }
}
