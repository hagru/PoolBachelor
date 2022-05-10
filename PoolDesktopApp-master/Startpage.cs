using AForge.Video.DirectShow;
using API_Class;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using System.Configuration;
using System.Collections.Specialized;

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
        public static bool connectedToDatabase = false;
        static bool onetime = false;
        public static FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice videoCaptureDevice;
        static HttpClient client = new HttpClient();
        static TextBox text = new TextBox();
        static bool check = false;
        GameConfig gamecon = new GameConfig();
        public bool connectClicked = false;
        public bool infoCollected = false;
        public int timeOut = 0;

        // Boolsk variabel for å sjekke om navn er oppgitt
        public bool nameOkay = false;
        public bool gameReady = false;

        public Startpage()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(175, Color.Black);
            Game game = new Game();
            game.Getplaycount();
            Game.count++;
            gameReady = false;
            check = false;
        }

        // Override for å redusere flickering ved loading av form og picturebokser
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        // Metode som setter navn
        public void SetName()
        {
            p1Name = txtPlayer1.Text;
            p2Name = txtPlayer2.Text;

            // Sjekker om navnefelt er fyllt ut - autofyller P1 og P2 dersom de ikke er fyllt ut
            if (p1Name == "" && p2Name == "" && connectedToDatabase == true)
            {
                nameOkay = true;
                p1Name = GameInfo.Username1;
                p2Name = GameInfo.Username2;
            }
            else if (p1Name == "" && p2Name == "" && connectedToDatabase == false)
            {
                nameOkay = true;
                p1Name = "Player 1";
                p2Name = "Player 2";
            }
            else if (p1Name == "" && p2Name != "" && connectedToDatabase == false)
            {
                nameOkay = true;
                p1Name = "Player 1";
            }
            else if (p1Name != "" && p2Name == "" && connectedToDatabase == false)
            {
                nameOkay = true;
                p2Name = "Player 2";
            }
            else if (p1Name != "" && p2Name != "" && connectedToDatabase == false)
            {
                p1Name = txtPlayer1.Text;
                p2Name = txtPlayer2.Text;
                nameOkay = true;
            }
        }

        // Metode som setter balltype
        public void SetBallType()
        {
            ballTypeP1 = "Solid";
            ballTypeP2 = "Half";

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

        public void StartGame()
        {
            GetInfo();
            SetName();
            SetBallType();
            SetCamera();

            if (nameOkay == true)
            {
                GameManager gameManager = new GameManager();
                gameManager.Show();
                nameOkay = false;
                timer1.Stop();
                this.Hide();
            }
        }

        // Click-event som starter spillet, og sender brukeren videre til hovedsiden
        private void btnStart_Click(object sender, EventArgs e)
        {
            connectedToDatabase = false;
            GameInfo.ConnectedToDatabase = connectedToDatabase;
            GetInfo();
            SetName();
            SetBallType();
            SetCamera();

            if (nameOkay == true)
            {
                GameManager gameManager = new GameManager();
                gameManager.Show();
                this.Hide();
            }
        }

        private void Startpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Application.ExitThread();
        }

        private void Startpage_Load(object sender, EventArgs e)
        {
            gameReady = false;
            connectClicked = true;
            lblInfo.Text = "Start game in webpage, or start a Quickgame";
            cboCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboCamera.Items.Add(filter.Name);
            }
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
            clientConfig();
            Thread.Sleep(3000);
            timer1.Start();
        }

        public void clientConfig()
        {
            if (onetime == false)
            {
                client.BaseAddress = new Uri("http://" + ConfigurationManager.AppSettings.Get("ipAddress") + ":80" + "/");
                onetime = true;
            }
        }


        private void btnStartSim_Click(object sender, EventArgs e)
        {
            connectedToDatabase = false;
            GameInfo.ConnectedToDatabase = connectedToDatabase;
            GetInfo();
            SetName();
            SetBallType();
            SetCamera();

            if (nameOkay == true)
            {
                Simulation simulation = new Simulation();
                simulation.Show();
                this.Hide();
            }
        }


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
                $"/UpdateTableStatus", path);
            response.EnsureSuccessStatusCode();
            return path;
        }


        public void GetInfo()
        {
            RunAsync2();
        }

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
                $"/GetInfo");
            info = await response.Content.ReadAsAsync<GameConfig>();
            GameInfo.GameID = info.GameID;
            GameInfo.PlayerID1 = info.PlayerID1;
            GameInfo.PlayerID2 = info.PlayerID2;
            GameInfo.Username1 = info.Username1;
            GameInfo.Username2 = info.Username2;
            if (GameInfo.PlayerID1 != 0)
            {
                text.Text = "ready";
                check = true;
            }
            return info;
        }

        public void TimeOut()
        {
            if (timeOut == 0)
            {
                lblInfo.Text = "Start game in webpage, or start a Quickgame";
            }

            else if (timeOut == 1)
            {
                lblInfo.Text = "Start game in webpage, or start a Quickgame.";
            }
            else if (timeOut == 2)
            {
                lblInfo.Text = "Start game in webpage, or start a Quickgame..";
            }

            if (timeOut == 3)
            {
                lblInfo.Text = "Start game in webpage, or start a Quickgame...";
                connectClicked = false;
                timeOut = 0;
            }
        }

        public void Connect()
        {
            if (GameInfo.GameID != 0)
            {
                lblInfo.Text = "Connected to game, start game in webpage!";
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
                lblInfo.Text = "Ready! Game starting!";
                btnStartGame.Enabled = true;

                gameReady = true;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            RunAsync();
            GetInfo();
            Connect();

            timeOut++;

            if (gameReady == true && check == true)
            {
                connectedToDatabase = true;
                GameInfo.ConnectedToDatabase = connectedToDatabase;
                lblInfo.Text = "Connected! Game starting!";
                gameReady = false;
                StartGame();
            }
        }

        public void EditText()
        {
            string batFilePath = @"..\..\camerasettings\webcamdialog.bat";
            if (!File.Exists(batFilePath))
            {
                using (FileStream fs = File.Create(batFilePath))
                {
                    fs.Close();
                }
            }

            using (StreamWriter sw = new StreamWriter(batFilePath))
            {
                sw.WriteLine(@"chcp 65001 > nul");
                sw.WriteLine("@set cam='" + cboCamera.Text + "'");
                sw.WriteLine("ffmpeg -f dshow -show_video_device_dialog true -i video=%cam%");
            }
            Process process = Process.Start(batFilePath);
            process.WaitForExit();
        }

        private void btnCameraSettings_Click(object sender, EventArgs e)
        {
            EditText();
            System.Diagnostics.Process.Start("launch.bat");
        }
    }
}

