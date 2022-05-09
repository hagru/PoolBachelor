using System.Configuration;

namespace Settings
{
    public partial class SettingsPage : Form
    {

        public string ipAddress = ConfigurationManager.AppSettings.Get("ipAddress");

        public SettingsPage()
        {
            InitializeComponent();
            txtIP.Text = ipAddress;
        }

        public void EditIP()
        {
            ConfigurationManager.AppSettings.Set("ipAddress", "10.8.0.6");
            ipAddress = ConfigurationManager.AppSettings.Get("ipAddress");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditIP();
            label1.Text = ipAddress;
        }
    }
}