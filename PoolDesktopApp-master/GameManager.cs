using System;
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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using API_Class;
using PoolDesktopApp.Properties;

namespace PoolDesktopApp
{
    public partial class GameManager : Form
    {
        Startpage startpage = new Startpage();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Image newPic;
        static Stopwatch stopwatch;
        Image img;
        Bitmap img1;

        Game game;
        BallDetection ballDetection;
        static HttpClient client = new HttpClient();

        // Counter for å se om alle ballene av dens slag er i hullet, for å vite om en kan putte svart
        public int counterHalf = 0;
        public int counterSolid = 0;

        // Lager objekter av alle ballene
        Ball ball0, ball1, ball2, ball3, ball4, ball5, ball6, ball7, ball8,
             ball9, ball10, ball11, ball12, ball13, ball14, ball15;

        // Lager objekter av spillere
        Player player1;
        Player player2;
        Player[] players = new Player[2];

        // Liste med baller som skal itereres gjennom
        List<Ball> listOfBalls = new List<Ball>();
        string[] balls = new string[20];

        // Variabler for å holde styr på hvem som har hvilke kuler, samt hvem sin tur det er
        public string player1Name;
        public string player2Name;
        public string p1BallType;
        public string p2BallType;
        public bool p1Turn = true;
        public bool p2Turn = false;
        public bool p1Half = false;
        public bool p1Solid = false;
        public bool p2Half = false;
        public bool p2Solid = false;
        public bool p1Lost = false;
        public bool p2Lost = false;
        public bool whiteDown = false;
        public bool bgWorkerActive = false;
        public bool p1Black = false;
        public bool p2Black = false;
        public int endGame = 0;
        static bool onetime;
        public bool gameOver = false;
        public int spacePresses = 0;

        public int counter = 0;
        public int shotCounter = 0;

        // Timer event som oppdaterer labelen med timer, formatert til å vise minutter og sekunder
        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed);
        }

        public GameManager()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(175, Color.Black);
            panel2.BackColor = Color.FromArgb(175, Color.Black);
            clientConfig();
            game = new Game();
            ballDetection = new BallDetection();
            game.ball_det1.PredictionConnection();
            Init();
            clientConfig();
        }

        // Override for å redusere flickering ved loading av form og picturebokser
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                return handleparam;
            }
        }


        // Metode som sjekker hvilke baller som er på bordet, og viser/fjerner de riktige ballene
        public void ShowBalls()
        {
            #region Check if ball is in list
            if (balls.Contains("white"))
            {
                ball0.IsOnTable = true;
            }
            if (balls.Contains("white") == false)
            {
                ball0.IsOnTable = false;
            }
            if (balls.Contains("yellow-whole"))
            {
                ball1.IsOnTable = true;
                p1Ball1.Visible = true;
            }
            if (balls.Contains("yellow-whole") == false)
            {
                ball1.IsOnTable = false;
                p1Ball1.Visible = false;
            }
            if (balls.Contains("blue-whole"))
            {
                ball2.IsOnTable = true;
                p1Ball2.Visible = true;
            }
            if (balls.Contains("blue-whole") == false)
            {
                ball2.IsOnTable = false;
                p1Ball2.Visible = false;
            }
            if (balls.Contains("red-whole"))
            {
                ball3.IsOnTable = true;
                p1Ball3.Visible = true;
            }
            if (balls.Contains("red-whole") == false)
            {
                ball3.IsOnTable = false;
                p1Ball3.Visible = false;
            }
            if (balls.Contains("purple-whole"))
            {
                ball4.IsOnTable = true;
                p1Ball4.Visible = true;
            }
            if (balls.Contains("purple-whole") == false)
            {
                ball4.IsOnTable = false;
                p1Ball4.Visible = false;
            }
            if (balls.Contains("orange-whole"))
            {
                ball5.IsOnTable = true;
                p1Ball5.Visible = true;
            }
            if (balls.Contains("orange-whole") == false)
            {
                ball5.IsOnTable = false;
                p1Ball5.Visible = false;
            }
            if (balls.Contains("green-whole"))
            {
                ball6.IsOnTable = true;
                p1Ball6.Visible = true;
            }
            if (balls.Contains("green-whole") == false)
            {
                ball6.IsOnTable = false;
                p1Ball6.Visible = false;
            }
            if (balls.Contains("brown-whole"))
            {
                ball7.IsOnTable = true;
                p1Ball7.Visible = true;
            }
            if (balls.Contains("brown-whole") == false)
            {
                ball7.IsOnTable = false;
                p1Ball7.Visible = false;
            }
            if (balls.Contains("black"))
            {
                ball8.IsOnTable = true;
            }
            if (balls.Contains("black") && p1Black == true)
            {
                ball8.IsOnTable = true;
                p1Ball8.Visible = true;
            }
            if (balls.Contains("black") == false)
            {
                ball8.IsOnTable = false;
                p2Ball8.Visible = true;
            }
            if (balls.Contains("black") && p2Black == true)
            {
                ball8.IsOnTable = true;
                p2Ball8.Visible = true;
            }
            if (balls.Contains("black") == false)
            {
                ball8.IsOnTable = false;
                p2Ball8.Visible = false;
            }
            if (balls.Contains("yellow-half"))
            {
                ball9.IsOnTable = true;
                p2Ball1.Visible = true;
            }
            if (balls.Contains("yellow-half") == false)
            {
                ball9.IsOnTable = false;
                p2Ball1.Visible = false;
            }
            if (balls.Contains("blue-half"))
            {
                ball10.IsOnTable = true;
                p2Ball2.Visible = true;
            }
            if (balls.Contains("blue-half") == false)
            {
                ball10.IsOnTable = false;
                p2Ball2.Visible = false;
            }
            if (balls.Contains("red-half"))
            {
                ball11.IsOnTable = true;
                p2Ball3.Visible = true;
            }
            if (balls.Contains("red-half") == false)
            {
                ball11.IsOnTable = false;
                p2Ball3.Visible = false;
            }
            if (balls.Contains("purple-half"))
            {
                ball12.IsOnTable = true;
                p2Ball4.Visible = true;
            }
            if (balls.Contains("purple-half") == false)
            {
                ball12.IsOnTable = false;
                p2Ball4.Visible = false;
            }
            if (balls.Contains("orange-half"))
            {
                ball13.IsOnTable = true;
                p2Ball5.Visible = true;
            }
            if (balls.Contains("orange-half") == false)
            {
                ball13.IsOnTable = false;
                p2Ball5.Visible = false;
            }
            if (balls.Contains("green-half"))
            {
                ball14.IsOnTable = true;
                p2Ball6.Visible = true;
            }
            if (balls.Contains("green-half") == false)
            {
                ball14.IsOnTable = false;
                p2Ball6.Visible = false;
            }
            if (balls.Contains("brown-half"))
            {
                ball15.IsOnTable = true;
                p2Ball7.Visible = true;
            }
            if (balls.Contains("brown-half") == false)
            {
                ball15.IsOnTable = false;
                p2Ball7.Visible = false;
            }
            #endregion
        }

        // Initialiserer spillet ved å legge til ballene i respektive lister, 
        // initialisere spillere, pluss starte stoppeklokka
        public void Init()
        {
            InitPlayer();
            AddBalls();
            LoadBalls();

            listOfBalls.Add(ball0);
            listOfBalls.Add(ball1);
            listOfBalls.Add(ball2);
            listOfBalls.Add(ball3);
            listOfBalls.Add(ball4);
            listOfBalls.Add(ball5);
            listOfBalls.Add(ball6);
            listOfBalls.Add(ball7);
            listOfBalls.Add(ball8);
            listOfBalls.Add(ball9);
            listOfBalls.Add(ball10);
            listOfBalls.Add(ball11);
            listOfBalls.Add(ball12);
            listOfBalls.Add(ball13);
            listOfBalls.Add(ball14);
            listOfBalls.Add(ball15);
        }

        public void ShowGameId()
        {
            if (GameInfo.ConnectedToDatabase == true)
            {
                lblGameId.Text = "Game ID:" + "\r\n" + GameInfo.GameID.ToString();
            }
            else if (GameInfo.ConnectedToDatabase == false)
            {
                lblGameId.Text = "Game ID:" + "\r\n" + "Quick game";
            }
        }

        public void EnableCamera()
        {
            // Henter valgt kamera fra Startpage
            int selectedCamera = 0;
            selectedCamera = Startpage.selectedCamera;

            filterInfoCollection = Startpage.filterInfoCollection;
            videoCaptureDevice = Startpage.videoCaptureDevice;

            // Formaterer videofeeden til 1280x720 og viser det i pictureboxen
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[selectedCamera].MonikerString);
            try
            {
                videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[7];
            }
            catch (Exception)
            {
                return;
            }

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        // Følgende blokker henter live video fra kamera, og viser det i applikasjonen ved oppstart
        private void DesktopApp_Load(object sender, EventArgs e)
        {
            // Viser GameID
            ShowGameId();
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                img = (Bitmap)eventArgs.Frame.Clone();
                pBoxMainGame.Image = img;
            }
            catch (Exception)
            {
                return;
            }
        }

        // Metode for å initialisere spillere
        public void InitPlayer()
        {
            players = game.InitPLayers();

            player1 = players[0];
            player2 = players[1];

            lblP1.Text = player1.Name;
            lblP2.Text = player2.Name;

            if (player1.PlayerTurn == true)
            {
                pBoxCueP1.Visible = false;
                pBoxCueP2.Visible = false;
            }
            else if (player2.PlayerTurn == true)
            {
                pBoxCueP1.Visible = false;
                pBoxCueP2.Visible = false;
            }
        }

        // Metode for å initialisere baller, og legge dem til riktig spiller
        public void AddBalls()
        {
            // Legger verdier til objektene av ballene
            #region Add balls as objects
            ball0 = new Ball("white", false, "", "White", 0, 0);
            ball1 = new Ball("yellowSolid", false, "images/yellowWhole.png", "Solid", 0, 0);
            ball2 = new Ball("blueSolid", false, "images/blueWhole.png", "Solid", 0, 0);
            ball3 = new Ball("redSolid", false, "images/redWhole.png", "Solid", 0, 0);
            ball4 = new Ball("purpleSolid", false, "images/purpleWhole.png", "Solid", 0, 0);
            ball5 = new Ball("orangeSolid", false, "images/orangeWhole.png", "Solid", 0, 0);
            ball6 = new Ball("greenSolid", false, "images/greenWhole.png", "Solid", 0, 0);
            ball7 = new Ball("brownSolid", false, "images/brownWhole.png", "Solid", 0, 0);
            ball8 = new Ball("black", false, "images/black.png", "Black", 0, 0);
            ball9 = new Ball("yellowHalf", false, "images/yellowHalf.png", "Half", 0, 0);
            ball10 = new Ball("blueHalf", false, "images/blueHalf.png", "Half", 0, 0);
            ball11 = new Ball("redHalf", false, "images/redHalf.png", "Half", 0, 0);
            ball12 = new Ball("purpleHalf", false, "images/purpleHalf.png", "Half", 0, 0);
            ball13 = new Ball("orangeHalf", false, "images/orangeHalf.png", "Half", 0, 0);
            ball14 = new Ball("greenHalf", false, "images/greenHalf.png", "Half", 0, 0);
            ball15 = new Ball("brownHalf", false, "images/brownHalf.png", "Half", 0, 0);
            #endregion
        }

        public void LoadBalls()
        {
            switch (player1.BallType)
            {
                case "Solid":
                    p1Ball1.Visible = true;
                    p1Ball2.Visible = true;
                    p1Ball3.Visible = true;
                    p1Ball4.Visible = true;
                    p1Ball5.Visible = true;
                    p1Ball6.Visible = true;
                    p1Ball7.Visible = true;
                    p1Solid = true;
                    break;
            }

            switch (player2.BallType)
            {
                case "Half":
                    p2Ball1.Visible = true;
                    p2Ball2.Visible = true;
                    p2Ball3.Visible = true;
                    p2Ball4.Visible = true;
                    p2Ball5.Visible = true;
                    p2Ball6.Visible = true;
                    p2Ball7.Visible = true;
                    p2Half = true;
                    break;
            }
        }

        // Metode som sjekker alle kulene, og hvilke kuler som er igjen på bordet
        public void CheckBalls()
        {
            counterSolid = 0;
            counterHalf = 0;

            foreach (var Ball in listOfBalls)
            {
                switch (Ball.IsOnTable)
                {
                    case true:
                        break;

                    case false:

                        if (Ball.IsOnTable == false && Ball.BallType == "Solid")
                        {
                            counterSolid += 1;

                            if (counterSolid >= 7)
                            {
                                p1Black = true;
                                p1Ball8.Visible = true;
                            }

                            else
                            {
                                p1Black = false;
                                p1Ball8.Visible = false;
                            }
                        }

                        else if (Ball.IsOnTable == false && Ball.BallType == "Half")
                        {
                            counterHalf += 1;

                            if (counterHalf >= 7)
                            {
                                p2Black = true;
                                p2Ball8.Visible = true;
                            }

                            else
                            {
                                p2Black = false;
                                p2Ball8.Visible = false;
                            }
                        }

                        break;
                }
            }
        }

        public void EditCamBat()
        {
            string batFilePath = "webcamdialog.bat";
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
                sw.WriteLine(@"set cam=" + '"' + GameInfo.CameraName + '"');
                sw.WriteLine("ffmpeg -f dshow -show_video_device_dialog true -i video=%cam%");
            }
        }

        private void DesktopApp_Activated(object sender, EventArgs e)
        {
            try
            {
                EnableCamera();
            }
            catch (Exception)
            {
                MessageBox.Show("Camera not woriking properly. Try restarting the program");
            }
        }


        private void GameManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                if (spacePresses == 0)
                {
                    stopwatch = new Stopwatch();
                    stopwatch.Start();
                    tmrGameTime.Enabled = true;
                    tmrGameTime.Start();

                }

                bgWorkerActive = true;
                bgWorker();
                backgroundWorker1.RunWorkerAsync();
                spacePresses++;
            }

            if (e.KeyChar == 9)
            {
                EditCamBat();
                Process.Start("launch.bat");
            }

            if (e.KeyChar == 82 || e.KeyChar == 114)
            {
                EnableCamera();
            }
        }

        private void DesktopApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoCaptureDevice.Stop();
            this.Hide();
            Startpage startpage = new Startpage();
            startpage.Show();
        }


        public void bgWorker()
        {
            try
            {
                pboLoading.Load("images/loading.gif");
                pboLoading.Enabled = true;
                pboLoading.Visible = true;
            }
            catch (Exception)
            {
                return;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Snapshot();
            ballDetection = game.ball_det1.DetectImage(img1);
            balls = ballDetection.balls;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowBalls();
            CheckBalls();
            CheckWhite();
            CheckBlack();
            CheckResult();
            TurnLogic();

            if (GameInfo.ConnectedToDatabase == true)
            {
                game.BilliardBall();
            }

            bgWorkerActive = false;
            pboLoading.Visible = false;

            shotCounter++;
        }


        // Metode for å gi cuen over til neste spiller
        public void Turn()
        {
            if (gameOver == false)
            {
                p1Turn = !p1Turn;
                p2Turn = !p2Turn;

                if (players[0].PlayerTurn == true)
                {
                    pBoxCueP1.Visible = true;
                    pBoxCueP2.Visible = false;
                }

                else if (players[1].PlayerTurn == true)
                {
                    pBoxCueP1.Visible = false;
                    pBoxCueP2.Visible = true;
                }
            }

            else
            {
                pBoxCueP1.Visible = false;
                pBoxCueP2.Visible = false;
            }

        }

        private void TurnLogic()
        {
            players = game.PlayerTurn1(ballDetection);
            Turn();
        }

        public void CheckWhite()
        {
            whiteDown = game.CheckWhite(ballDetection);
        }

        // Metode som sjekker om svart er puttet, og om det evt er flere baller av en sort på bordet
        // noe som vil bety at den andre vinner
        public void CheckBlack()
        {
            if (listOfBalls[8].IsOnTable == false)
            {
                if (p1Turn == false && whiteDown == true)
                {
                    p1Lost = true;
                }
                else if (p2Turn == false && whiteDown == true)
                {
                    p2Lost = true;
                }

                else
                {
                    if (counterHalf < 7)
                    {
                        if (p1Half == true && p1Turn == false)
                        {
                            p1Lost = true;
                        }
                        else if (p2Half == true && p2Turn == false)
                        {
                            p2Lost = true;
                        }
                    }

                    else if (counterHalf >= 7)
                    {
                        if (p1Half == true && p1Turn == false)
                        {
                            p2Lost = true;
                        }
                        else if (p2Half == true && p2Turn == false)
                        {
                            p1Lost = true;
                        }
                    }

                    if (counterSolid < 7)
                    {
                        if (p1Solid == true && p1Turn == false)
                        {
                            p1Lost = true;
                        }
                        else if (p2Solid == true && p2Turn == false)
                        {
                            p2Lost = true;
                        }
                    }

                    else if (counterSolid >= 7)
                    {
                        if (p1Solid == true && p1Turn == false)
                        {
                            p2Lost = true;
                        }
                        else if (p2Solid == true && p2Turn == false)
                        {
                            p1Lost = true;
                        }
                    }
                }
            }
        }

        public void CheckResult()
        {
            if (p1Lost == true)
            {
                gameOver = true;
                stopwatch.Stop();

                lblWinner.Text = player2.Name + " wins!";
                lblWinner.Visible = true;
                if (GameInfo.ConnectedToDatabase == true)
                {
                    players[0].Lose = true;
                    players[0].Win = false;
                    players[1].Lose = false;
                    players[1].Win = true;
                    game.Update(players);
                    game.UpdateTimeStamp();
                    RunAsync();
                }
                tmrEndGame.Enabled = true;
                tmrEndGame.Start();
            }

            else if (p2Lost == true)
            {
                gameOver = true;
                stopwatch.Stop();

                lblWinner.Text = player1.Name + " wins!";
                lblWinner.Visible = true;
                if (GameInfo.ConnectedToDatabase == true)
                {
                    players[1].Lose = true;
                    players[0].Win = true;
                    players[1].Win = false;
                    players[0].Lose = false;
                    game.Update(players);
                    game.UpdateTimeStamp();
                    RunAsync();
                }
                tmrEndGame.Enabled = true;
                tmrEndGame.Start();
            }
        }


        private void tmrEndGame_Tick(object sender, EventArgs e)
        {
            endGame++;

            if (endGame == 8 && (p1Lost == true || p2Lost == true))
            {
                videoCaptureDevice.Stop();
                this.Hide();
                Thread.Sleep(200);
                Startpage startpage = new Startpage();
                startpage.Show();
            }
        }


        public void Snapshot()
        {
            try
            {
                newPic = (Bitmap)img.Clone();
                Bitmap croppedPic = new Bitmap(newPic);
                img1 = new Bitmap(croppedPic);
            }
            catch (Exception)
            {
                return;
            }
        }


        static async Task RunAsync()
        {
            GameConfig product = new GameConfig
            {
                GameStart = true,
                PlayerID1 = 0,
                PlayerID2 = 0,
                GameID = 0
            };
            GameConfig f = await SetGameStartAsync(product);
        }
        static async Task<GameConfig> SetGameStartAsync(GameConfig path)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/GameStop", path);
            response.EnsureSuccessStatusCode();
            return path;
        }

        public void clientConfig()
        {
            if (onetime == false)
            {
                client.BaseAddress = new Uri("http://" + ConfigurationManager.AppSettings.Get("ipAddress") + ":80" + "/");
                onetime = true;
            }
        }
    }
}

