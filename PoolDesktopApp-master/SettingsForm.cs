﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Class;

namespace PoolDesktopApp
{
    public partial class SettingsForm : Form
    {
        public string ipAddress = ConfigurationManager.AppSettings.Get("ipAddress");
        static HttpClient client = new HttpClient();

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

        static async Task RunAsyncSettings()
        {
            GameConfig product = new GameConfig
            {
                IP = "http://" + ConfigurationManager.AppSettings.Get("ipAddress") + ":80" + "/"
            };
            GameConfig f = await SetUpdateSettings(product);
        }

        static async Task<GameConfig> SetUpdateSettings(GameConfig path)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/UpdateSettings", path);
            response.EnsureSuccessStatusCode();
            return path;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EditIP();
            RunAsyncSettings();
            
            txtCurrentIP.Text = ipAddress;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}