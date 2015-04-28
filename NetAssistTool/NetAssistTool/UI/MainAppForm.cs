using NetAssistTool.Core;
using NetAssistTool.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetAssistTool.UI
{
    public partial class MainAppForm : Form, IObserver
    {
        private NetServer netServer = new NetServer();

        public MainAppForm()
        {
            netServer.Attach(this);
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem_Click(sender, e);
        }

        private void sysIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             
        }

        private void startServiceButton_Click(object sender, EventArgs e)
        {
            if (CheckSettings())
            {
                netServer.StartService();
                startServiceButton.Enabled = !netServer.IsRunning();
                iniciarServiçoToolStripMenuItem.Enabled = !netServer.IsRunning();
                pararServiçoToolStripMenuItem.Enabled = !netServer.IsRunning();
                stopServiceButton.Enabled = netServer.IsRunning();

                logTextBox.Text += "Serviço iniciado" + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Um ou mais valores estão incorretos ou incompletos." + Environment.NewLine + "Verifique as configurações e preencha os campos corretamente.", "Verificar configurações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new ConfigForm().ShowDialog();
            }
        }

        private bool CheckSettings()
        {
            Properties.Settings.Default.Reload();
            string localServerName = (string)Properties.Settings.Default["LocalServerName"];
            long ttl = Convert.ToInt64(Properties.Settings.Default["TTL"]);
            int hops = Convert.ToInt32(Properties.Settings.Default["Hops"]);
            ArrayList externalServers = (ArrayList)Properties.Settings.Default["ExternalServers"];
            return (!String.IsNullOrEmpty(localServerName) &&
                !String.IsNullOrEmpty(Convert.ToString(ttl)) &&
                !String.IsNullOrEmpty(Convert.ToString(hops)) &&
                externalServers.Count > 0);
        }

        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            netServer.StopService();
            stopServiceButton.Enabled = netServer.IsRunning();
            startServiceButton.Enabled = !netServer.IsRunning();
            iniciarServiçoToolStripMenuItem.Enabled = !netServer.IsRunning();
            pararServiçoToolStripMenuItem.Enabled = netServer.IsRunning();

            logTextBox.Text += "Serviço interrompido" + Environment.NewLine;
        }

        private void iniciarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startServiceButton_Click(sender, e);
        }

        private void pararServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopServiceButton_Click(sender, e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            netServer.Detach(this);
            netServer.StopService();
        }

        public void Update(Subject subject)
        {
            if (subject == netServer)
                DisplayMessage(netServer.GetLog());
        }

        private delegate void SetTextCallback(String displayMessage);

        private void DisplayMessage(String message)
        {
            if (!String.IsNullOrEmpty(message))
                if (this.logTextBox.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(DisplayMessage);
                    this.Invoke(d, new object[] { message });
                    return;
                }
                else
                    logTextBox.Text += message + Environment.NewLine;
        }
    }
}
