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
    public partial class ConfigForm : Form
    {
        private ArrayList serverList = new ArrayList();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hostnameListTextBox.Text.Trim()))
            {
                serverList.Add(hostnameListTextBox.Text.Trim());
                hostnameListBox.DataSource = null;
                hostnameListBox.DataSource = serverList;
                hostnameListTextBox.Clear();
                hostnameListTextBox.Focus();
            }
            else
                hostnameListTextBox.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serverList.Count > 0 && hostnameListBox.SelectedIndex > -1)
            {
                serverList.RemoveAt(serverList.IndexOf(hostnameListBox.SelectedItem));
                hostnameListBox.DataSource = null;
                hostnameListBox.DataSource = serverList;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void SaveSettings()
        {
            if (IsSafeToSave())
            {
                Properties.Settings.Default["LocalServerName"] = hostnameTextBox.Text.Trim();
                Properties.Settings.Default["TTL"] = Convert.ToInt64(timedoutTextBox.Text.Trim());
                Properties.Settings.Default["Hops"] = Convert.ToInt32(hopsTextBox.Text.Trim());
                Properties.Settings.Default["ExternalServers"] = serverList;
            }
            else
            {
                MessageBox.Show("Um ou mais valores estão incorretos ou incompletos." + Environment.NewLine + "Você terá problemas ao iniciar o serviço", "Configurações incompletas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Properties.Settings.Default["LocalServerName"] = String.Empty;
                Properties.Settings.Default["TTL"] = null;
                Properties.Settings.Default["Hops"] = null;
                Properties.Settings.Default["ExternalServers"] = null;
            }

            Properties.Settings.Default.Save();

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void ReadSettings()
        {
            Properties.Settings.Default.Reload();
            hostnameTextBox.Text = (String)Properties.Settings.Default["LocalServerName"];
            timedoutTextBox.Text = Convert.ToString(Properties.Settings.Default["TTL"]);
            hopsTextBox.Text = Convert.ToString(Properties.Settings.Default["Hops"]);
            if ((ArrayList)Properties.Settings.Default["ExternalServers"] != null)
                serverList = (ArrayList)Properties.Settings.Default["ExternalServers"];
            hostnameListBox.DataSource = serverList;
        }

        private void ConfigForm_Shown(object sender, EventArgs e)
        {
            ReadSettings();
        }

        private bool IsSafeToSave()
        {
            return (!string.IsNullOrEmpty(hostnameTextBox.Text.Trim()) &&
                    !string.IsNullOrEmpty(timedoutTextBox.Text.Trim()) &&
                    !string.IsNullOrEmpty(hopsTextBox.Text.Trim()) &&
                    serverList.Count > 0);
        }
    }
}
