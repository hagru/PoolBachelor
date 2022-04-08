using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_Class;
using System.Net.Http;
using System.Data.SqlClient;

namespace PoolDesktopApp
{
    public partial class Startpage : Form
    {
        // Deklarerer tomme variabler som skal fylles ut og sendes videre
        public static string p1Name = "";
        public static string p2Name = "";
        public static int gameID = 0;
        public static string ballTypeP1 = "";
        public static string ballTypeP2 = "";
        public static bool solidBall = false;
        public static bool halfBall = false;
        public static bool simulationMode = false;
        public static int selectedCamera = 0;
        public static FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice videoCaptureDevice;
        public bool connectClicked = false;
        public bool infoCollected = false;
        public int timeOut = 0;

        // Boolsk variabel for å sjekke om navn er oppgitt
        public bool nameOkay = false;

        public Startpage()
        {
            InitializeComponent();
            Game game = new Game();
            game.Getplaycount();
        }

        // Metode som setter navn
        public void SetName()
        {
            //p1Name = "Sander";
            //p2Name = "Amanuel";

            // Sjekker om navnefelt er fyllt ut
            if (p1Name == "" && p2Name == "")
            {
                nameOkay = true;
                p1Name = GameInfo.Username1;
                p2Name = GameInfo.Username2;
                //nameOkay = false;
                //MessageBox.Show("Mangler navn");
            }
            else if (p1Name == "" && p2Name != "")
            {
                nameOkay = true;
                p1Name = "Amanuel";
            }
            else if (p1Name != "" && p2Name == "")
            {
                nameOkay = true;
                p2Name = "Sander";
            }
            else
            {
                nameOkay = true;
            }
        }

        public void SetNameSim()
        {
            //p1Name = txtP1Name.Text;
            //p2Name = txtP2Name.Text;

            // Sjekker om navnefelt er fyllt ut
            if (p1Name == "" && p2Name == "")
            {
                nameOkay = true;
                p1Name = "Sander";
                p2Name = "Amanuel";
                //nameOkay = false;
                //MessageBox.Show("Mangler navn");
            }
            else if (p1Name == "" && p2Name != "")
            {
                nameOkay = true;
                p1Name = "Amanuel";
            }
            else if (p1Name != "" && p2Name == "")
            {
                nameOkay = true;
                p2Name = "Sander";
            }
            else
            {
                nameOkay = true;
            }
        }

        // Metode som setter balltype etter valg i drop down lista
        public void SetBallType()
        {
            //ballTypeP1 = cboSelectBall.Text;
            if (rdoHalf.Checked == true)
            {
                ballTypeP1 = "Half";
            }
            else if (rdoSolid.Checked == true)
            {
                ballTypeP1 = "Solid";
            }
            

            if (ballTypeP1 == "Solid")
            {
                solidBall = true;
                ballTypeP2 = "Half";
            }
            else
            {
                halfBall = true;
                ballTypeP2 = "Solid";
            }
        }

        public void SetBallTypeSim()
        {
            if (ballTypeP1 == "Solid")
            {
                solidBall = true;
                ballTypeP2 = "Half";
            }
            else
            {
                halfBall = true;
                ballTypeP2 = "Solid";
            }
        }

        public void SetCamera()
        {
            selectedCamera = cboCamera.SelectedIndex;
        }

        // Click-event som starter spillet, og sender brukeren videre til hovedsiden
        private void btnStart_Click(object sender, EventArgs e)
        {
            GetInfo();
            SetName();
            SetBallType();
            SetCamera();

            if (nameOkay == true)
            {
                DesktopApp desktopApp = new DesktopApp();
                desktopApp.Show();
                this.Hide();
            }
        }

        private void Startpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            timer1.Stop();
        }

        private void Startpage_Load(object sender, EventArgs e)
        {
            txtInfo.Text = "Trykk 'Connect' for å koble til et opprettet spill";
            cboCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboCamera.Items.Add(filter.Name);
            }
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            client.BaseAddress = new Uri("http://10.8.0.2:80/");
            timer1.Start();
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            simulationMode = true;
            SetNameSim();
            SetBallTypeSim();

            if (nameOkay == true)
            {
                SimulationApp simulationApp = new SimulationApp();
                simulationApp.Show();
                this.Hide();
            }
        }


        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            txtInfo.Text = ".";
            connectClicked = true;
            RunAsync();

        }
        static HttpClient client = new HttpClient();

        static async Task RunAsync()
        {

            GameConfig product = new GameConfig
            {
                GameStart = true
            };
            GameConfig f = await SetGameStartAsync(product);
        }
        static async Task<GameConfig> SetGameStartAsync(GameConfig path)
        {
            
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/update", path);
            int b = 0;
            response.EnsureSuccessStatusCode();
            return path;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInfo.Text = text.Text;
            GetInfo();
        }
        void GetInfo()
        {
            RunAsync2();
        }
        GameConfig gamecon = new GameConfig();
        
        static async Task<GameConfig> RunAsync2()
        {
            GameConfig gamecon = null;
            GameConfig f = await GetInfoAsync(gamecon);
            GameConfig gameinfo = null;
            return gameinfo;
        }
        static async Task<GameConfig> GetInfoAsync(GameConfig path)
        {
            GameConfig info = null;
            HttpResponseMessage response = await client.GetAsync(
                $"/getinfo");
            int b = 0;
            info = await response.Content.ReadAsAsync<GameConfig>();
            GameInfo.GameID = info.GameID;
            GameInfo.PlayerID1 = info.PlayerID1;
            GameInfo.PlayerID2 = info.PlayerID2;
            GameInfo.Username1 = info.Username1;
            GameInfo.Username2 = info.Username2;
            if (GameInfo.PlayerID1 != 0)
            {
                text.Text = "ready";
            }
            return info;
        }
        static TextBox text = new TextBox();

        public void TimeOut()
        {
            if (timeOut == 0)
            {
                txtInfo.Text = ".";
            }

            else if (timeOut == 10)
            {
                txtInfo.Text = "..";
            }
            else if (timeOut == 20)
            {
                txtInfo.Text = "...";
            }

            if (timeOut == 30)
            {
                txtInfo.Text = "Fant ikke spill. Prøv igjen";
                connectClicked = false;
                timeOut = 0;
            }
        }

        public void Connect()
        {
      
            if (GameInfo.GameID != 0)
            {
                txtInfo.Text = "Du er koblet til! Start spillet i websiden";
                btnConnect.Enabled = false;
                btnConnect.BackColor = Color.Green;
                Connected();
            }

            else
            {
                TimeOut();
            }

            
        }

        public void Connected()
        {
            if (GameInfo.PlayerID1 != 0)
            {
                txtInfo.Text = "Informasjon er hentet, start spillet.";
                btnStartGame.Enabled = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (connectClicked == true)
            {
                Connect();

                timeOut++;
            }

            //txtInfo.Text = text.Text + GameInfo.PlayerID1 + GameInfo.Username1 + GameInfo.Username2 
            //    + GameInfo.GameID;
            
            GetInfo();


        }
    }
}
