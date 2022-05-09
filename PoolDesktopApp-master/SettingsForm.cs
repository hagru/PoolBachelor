using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolDesktopApp
{
    public partial class SettingsForm : Form
    {
        public string ipAddress = ConfigurationManager.AppSettings.Get("ipAddress");

        public SettingsForm()
        {
            InitializeComponent();
            txtIP.Text = ipAddress;
            txtCurrentIP.Text = ipAddress;
        }


        public void EditIP()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ipAddress"].Value = txtIP.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            
            ipAddress = ConfigurationManager.AppSettings.Get("ipAddress");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditIP();
            txtCurrentIP.Text = ipAddress;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
