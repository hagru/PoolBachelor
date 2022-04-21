﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using PoolDesktopApp.Properties;

namespace PoolDesktopApp
{
    public partial class DesktopApp : Form
    {
        Startpage startpage = new Startpage();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Image newPic;
        Image img;
        Bitmap img1;


        Game game;
        BallDetection ballDetection;

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

       

        public int counter = 0;
        public int shotCounter = 0;

        // Objekt av stoppeklokke for timer
        private Stopwatch stopwatch;


        // Timer event som oppdaterer labelen med timer, formatert til å vise minutter og sekunder
        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed);

        }

        Image oldpic = null;
        bool PicComparer()
        {
            if (oldpic == null)
            {
                return true;
            }

            else
            {
                Image s = newPic;
                Image w = oldpic;
                Bitmap img1 = new Bitmap((Bitmap)newPic, 1800, 900);
                Bitmap img2 = new Bitmap((Bitmap)w);

                if (img1.Size != img2.Size)
                {
                    Console.Error.WriteLine("Images are of different sizes");

                }

                float diff = 0;

                for (int y = 0; y < img1.Height; y++)
                {
                    for (int x = 0; x < img1.Width; x++)
                    {
                        Color pixel1 = img1.GetPixel(x, y);
                        Color pixel2 = img2.GetPixel(x, y);
                        diff += Math.Abs(pixel1.R - pixel2.R);
                        diff += Math.Abs(pixel1.G - pixel2.G);
                        diff += Math.Abs(pixel1.B - pixel2.B);
                    }
                }
                oldpic = newPic;
                double bi = 0;
                bi = 100 * (diff / 255) / (img1.Width * img1.Height * 3);
                if (bi <= 0.01)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public DesktopApp()
        {
            InitializeComponent();
            tmrGameTime.Start();
            game = new Game();
            ballDetection = new BallDetection();
            Init();
            
        }

        public void ShowBalls()
        {

          //ballDetection = game.ball_det1.TestIteration(img1);
            string[] ballNames = { "white", "yellow-whole", "blue-whole", "red-whole", "purple-whole", "orange-whole", "green-whole", "brown-whole", "black", "yellow-half",
                "blue-half", "red-half", "purple-half", "orange-half", "green-half", "brown-half"};

            //balls = ballDetection.balls;

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
                //ball1.ImageString = ("../../images/yellowWhole.png");
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
                //ball2.ImageString = ("../../images/blueWhole.png");
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
                //ball3.ImageString = ("../../images/redWhole.png");
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
                //ball4.ImageString = ("../../images/purpleWhole.png");
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
                //ball5.ImageString = ("../../images/orangeWhole.png");
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
                //ball6.ImageString = ("../../images/greenWhole.png");
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
                //ball7.ImageString = ("../../images/brownWhole.png");
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
                //ball9.ImageString = ("../../images/yellowHalf.png");
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
                //ball10.ImageString = ("../../images/blueHalf.png");
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
                //ball11.ImageString = ("../../images/redHalf.png");
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
                //ball12.ImageString = ("../../images/purpleHalf.png");
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
                //ball13.ImageString = ("../../images/orangeHalf.png");
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
                //ball14.ImageString = ("../../images/greenHalf.png");
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
                //ball15.ImageString = ("../../images/brownHalf.png");
                p2Ball7.Visible = true;
            }
            if (balls.Contains("brown-half") == false)
            {
                ball15.IsOnTable = false;
                p2Ball7.Visible = false;
            }
        }

        // Initialiserer spillet ved å legge til ballene i respektive lister, 
        // initialisere spillere, pluss starte stoppeklokka
        public void Init()
        {
            InitPlayer();
            AddBalls();
            LoadBalls();

            stopwatch = new Stopwatch();
            stopwatch.Start();

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

            //ShowBalls();

        }



        // Følgende blokker henter live video fra kamera, og viser det i applikasjonen ved oppstart
        private void DesktopApp_Load(object sender, EventArgs e)
        {
            if (GameInfo.ConnectedToDatabase == true)
            {
                lblGameId.Text = "Game ID: " + GameInfo.GameID.ToString();
            }
            else if (GameInfo.ConnectedToDatabase == false)
            {
                lblGameId.Text = "Game ID: Quick game";
            }




            //Henter valgt kamera fra Startpage
            int selectedCamera = 0;
            selectedCamera = Startpage.selectedCamera;

            filterInfoCollection = Startpage.filterInfoCollection;
            videoCaptureDevice = Startpage.videoCaptureDevice;

            // Formaterer videofeeden til 1920x1080 og viser det i pictureboxen
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[selectedCamera].MonikerString);
            try
            {
                videoCaptureDevice.VideoResolution = videoCaptureDevice.VideoCapabilities[9];
                for (int i = 0; i < videoCaptureDevice.VideoCapabilities.Length; i++)
                {
                    string resolution = "Resolution Number " + Convert.ToString(i);
                    string resolution_size = videoCaptureDevice.VideoCapabilities[i].FrameSize.ToString();
                }
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
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
                //pBoxCueP1.Load("../../images/CueF.png");
                //pBoxCueP2.Load("../../images/control.png");
                pBoxCueP1.Visible = false;
                pBoxCueP2.Visible = false;
            }
            else if (player2.PlayerTurn == true)
            {
                //pBoxCueP1.Load("../../images/control.png");
                //pBoxCueP2.Load("../../images/Cue.png");
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
            ball1 = new Ball("yellowSolid", false, "../../images/yellowWhole.png", "Solid", 0, 0);
            ball2 = new Ball("blueSolid", false, "../../images/blueWhole.png", "Solid", 0, 0);
            ball3 = new Ball("redSolid", false, "../../images/redWhole.png", "Solid", 0, 0);
            ball4 = new Ball("purpleSolid", false, "../../images/purpleWhole.png", "Solid", 0, 0);
            ball5 = new Ball("orangeSolid", false, "../../images/orangeWhole.png", "Solid", 0, 0);
            ball6 = new Ball("greenSolid", false, "../../images/greenWhole.png", "Solid", 0, 0);
            ball7 = new Ball("brownSolid", false, "../../images/brownWhole.png", "Solid", 0, 0);
            ball8 = new Ball("black", false, "../../images/black.png", "Black", 0, 0);
            ball9 = new Ball("yellowHalf", false, "../../images/yellowHalf.png", "Half", 0, 0);
            ball10 = new Ball("blueHalf", false, "../../images/blueHalf.png", "Half", 0, 0);
            ball11 = new Ball("redHalf", false, "../../images/redHalf.png", "Half", 0, 0);
            ball12 = new Ball("purpleHalf", false, "../../images/purpleHalf.png", "Half", 0, 0);
            ball13 = new Ball("orangeHalf", false, "../../images/orangeHalf.png", "Half", 0, 0);
            ball14 = new Ball("greenHalf", false, "../../images/greenHalf.png", "Half", 0, 0);
            ball15 = new Ball("brownHalf", false, "../../images/brownHalf.png", "Half", 0, 0);
            #endregion

            // Switch case for å vite hvilken spiller som har halve eller hele kuler, og legge kulene i rett
            // sett med pictureboxes

        }

        

        public void LoadBalls()
        {
            switch (player1.BallType)
            {
                //case "Half":
                //    p1Ball1.Load(ball9.ImageString);
                //    p1Ball2.Load(ball10.ImageString);
                //    p1Ball3.Load(ball11.ImageString);
                //    p1Ball4.Load(ball12.ImageString);
                //    p1Ball5.Load(ball13.ImageString);
                //    p1Ball6.Load(ball14.ImageString);
                //    p1Ball7.Load(ball15.ImageString);
                //    p1Half = true;
                //    break;
                case "Solid":
                    p1Ball1.Visible = true;/*Load(ball1.ImageString);*/
                    p1Ball2.Visible = true;/*Load(ball2.ImageString);*/
                    p1Ball3.Visible = true;/*Load(ball3.ImageString);*/
                    p1Ball4.Visible = true;/*Load(ball4.ImageString);*/
                    p1Ball5.Visible = true;/*Load(ball5.ImageString);*/
                    p1Ball6.Visible = true;/*Load(ball6.ImageString);*/
                    p1Ball7.Visible = true;/*Load(ball7.ImageString);*/
                    p1Solid = true;
                    break;
            }

            switch (player2.BallType)
            {
                case "Half":
                    p2Ball1.Visible = true;/*Load(ball9.ImageString);*/
                    p2Ball2.Visible = true;/*Load(ball10.ImageString);*/
                    p2Ball3.Visible = true;/*Load(ball11.ImageString);*/
                    p2Ball4.Visible = true;/*Load(ball12.ImageString);*/
                    p2Ball5.Visible = true;/*Load(ball13.ImageString);*/
                    p2Ball6.Visible = true;/*Load(ball14.ImageString);*/
                    p2Ball7.Visible = true;/*Load(ball15.ImageString);*/
                    p2Half = true;
                    break;
                    //case "Solid":
                    //    p2Ball1.Load(ball1.ImageString);
                    //    p2Ball2.Load(ball2.ImageString);
                    //    p2Ball3.Load(ball3.ImageString);
                    //    p2Ball4.Load(ball4.ImageString);
                    //    p2Ball5.Load(ball5.ImageString);
                    //    p2Ball6.Load(ball6.ImageString);
                    //    p2Ball7.Load(ball7.ImageString);
                    //    p2Solid = true;
                    //break;
            }
        }


        // Metode som sjekker alle kulene, og hvilke kuler som er igjen på bordet
        public void CheckBalls()
        {
            counterSolid = 0;
            counterHalf = 0;

            //ShowBalls();

            foreach (var Ball in listOfBalls)
            {
                switch (Ball.IsOnTable)
                {
                    case true:
                        //BallType();

                        break;
                    case false:
                        //Ball.ImageString = ("../../images/transparent.png");

                        //BallType();


                        if (Ball.IsOnTable == false && Ball.BallType == "Solid")
                        {
                            counterSolid += 1;

                            if (counterSolid >= 7)
                            {

                                //p1Ball8.Load("../../images/black.png");
                                p1Black = true;
                                p1Ball8.Visible = true;



                            }
                        }

                        else if (Ball.IsOnTable == false && Ball.BallType == "Half")
                        {
                            counterHalf += 1;

                            if (counterHalf >= 7)
                            {

                                //p2Ball8.Load("../../images/black.png");
                                p2Black = true;
                                p2Ball8.Visible = true;

                            }
                        }
                        break;
                }
            }
            //ShowBalls();
        }

        // Metode for å sjekke hvem som har hvilke baller, og legge riktig baller til riktig spiller
        public void BallType()
        {
            try
            {
                switch (player1.BallType)
                {
                    case "Solid":
                        p1Ball1.Visible = true;/*Load(ball1.ImageString);*/
                        p1Ball2.Visible = true;/*Load(ball2.ImageString);*/
                        p1Ball3.Visible = true;/*Load(ball3.ImageString);*/
                        p1Ball4.Visible = true;/*Load(ball4.ImageString);*/
                        p1Ball5.Visible = true;/*Load(ball5.ImageString);*/
                        p1Ball6.Visible = true;/*Load(ball6.ImageString);*/
                        p1Ball7.Visible = true;/*Load(ball7.ImageString);*/
                        break;

                        //case "Half":
                        //    p1Ball1.Load(ball9.ImageString);
                        //    p1Ball2.Load(ball10.ImageString);
                        //    p1Ball3.Load(ball11.ImageString);
                        //    p1Ball4.Load(ball12.ImageString);
                        //    p1Ball5.Load(ball13.ImageString);
                        //    p1Ball6.Load(ball14.ImageString);
                        //    p1Ball7.Load(ball15.ImageString);
                        //    break;
                }

                switch (player2.BallType)
                {
                    //case "Solid":
                    //    p2Ball1.Load(ball1.ImageString);
                    //    p2Ball2.Load(ball2.ImageString);
                    //    p2Ball3.Load(ball3.ImageString);
                    //    p2Ball4.Load(ball4.ImageString);
                    //    p2Ball5.Load(ball5.ImageString);
                    //    p2Ball6.Load(ball6.ImageString);
                    //    p2Ball7.Load(ball7.ImageString);
                    //    break;

                    case "Half":
                        p2Ball1.Visible = true;/* Load(ball9.ImageString);*/
                        p2Ball2.Visible = true;/* Load(ball10.ImageString);*/
                        p2Ball3.Visible = true;/* Load(ball11.ImageString);*/
                        p2Ball4.Visible = true;/* Load(ball12.ImageString);*/
                        p2Ball5.Visible = true;/* Load(ball13.ImageString);*/
                        p2Ball6.Visible = true;/* Load(ball14.ImageString);*/
                        p2Ball7.Visible = true;/* Load(ball15.ImageString);*/
                        break;
                }
            }
            catch (Exception)
            {

                return;
            }

        }

        public void bgWorker()
        {
            if (bgWorkerActive == true)
            {
                //btnProcess.Enabled = false;
                //btnProcess.BackColor = SystemColors.Control;
                //btnProcess.Text = "";
                pboLoading.Enabled = true;
                pboLoading.Show();
                pboLoading.Load("../../images/loading.gif");
                pboLoading.Visible = true;
                //pboLoading.Load("../../images/black.png");
            }

            else
            {
                //pboLoading.Hide();
                //btnProcess.Enabled = true;
                //btnProcess.Text = "PROCESS";
                //btnProcess.BackColor = Color.SteelBlue;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            bgWorkerActive = true;
            bgWorker();
            backgroundWorker1.RunWorkerAsync();
            //btnProcess.Enabled = false;
            //btnProcess.BackColor = SystemColors.Control;
            //btnProcess.Text = "PROCESSING";
            //pboLoading.Enabled = true;
            //pboLoading.Show();
            //pboLoading.Load("../../images/loading.gif");

            //Snapshot();
            //CheckBalls();

            // Ny thread for det tunge arbeidet, slik at den ikke blokkerer andre viktige ting
            //await Task.Run(() =>
            //{

            //    //LoadBalls();
            //    //Snapshot();

            //});
            //CheckWhite();
            //CheckBlack();
            //CheckResult();
            //game.BilliardBall();

            //if (shotCounter > 0)
            //{
            //    TurnLogic();
            //}
            //LoadBalls();


            //pboLoading.Hide();
            //btnProcess.Enabled = true;
            //btnProcess.Text = "PROCESS";
            //btnProcess.BackColor = Color.SteelBlue;


            shotCounter++;
        }
        private void DesktopApp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 32)
            {
                //Snapshot();
                //ShowBalls();
                bgWorkerActive = true;
                bgWorker();
                backgroundWorker1.RunWorkerAsync();
            }
            tmrEndGame.Start();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Snapshot();
            ballDetection = game.ball_det1.TestIteration(img1);
            balls = ballDetection.balls;
            //ShowBalls();
            //CheckBalls();
            //CheckWhite();
            //CheckBlack();
            //CheckResult();
            bgWorkerActive = false;
            bgWorker();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (shotCounter > 0)
            //{
            //    TurnLogic();
            //    game.BilliardBall();
            //}
            //LoadBalls();


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
            
            //LoadBalls();
            pboLoading.Visible = false;


            shotCounter++;

        }


        // Metode for å gi cuen over til neste spiller
        public void Turn()
        {
            p1Turn = !p1Turn;
            p2Turn = !p2Turn;

            if (players[0].PlayerTurn == true)
            {
                //pBoxCueP1.Load("../../images/CueF.png");
                //pBoxCueP2.Load("../../images/transparent.png");
                pBoxCueP1.Visible = true;
                pBoxCueP2.Visible = false;
            }

            else if (players[1].PlayerTurn == true)
            {
                //pBoxCueP1.Load("../../images/transparent.png");
                //pBoxCueP2.Load("../../images/Cue.png");
                pBoxCueP1.Visible = false;
                pBoxCueP2.Visible = true;
            }

        }

        private void TurnLogic()
        {
            players = game.PlayerTurn1(ballDetection);
            Turn();
        }

        public void CheckWhite()
        {
            whiteDown = game.CheckWhite();
        }

        // Metode som sjekker om svart er puttet, og om det evt er flere baller av en sort på bordet
        // noe som vil bety at den andre vinner
        public void CheckBlack()
        {
            //whiteDown = game.CheckWhite();

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
               
                stopwatch.Stop();
                MessageBox.Show(player2.Name + " vinner!");
                lblWinner.Text = player2.Name + " vinner!";
                lblWinner.Visible = true;
                if (GameInfo.ConnectedToDatabase == true)
                {
                    players[0].lose = true;
                    players[0].win = false;
                    players[1].lose = false;
                    players[1].win = true;
                    game.Update(players);
                    game.UpdateTimeStamp();
                }
                tmrEndGame.Enabled = true;
                tmrEndGame.Start();
                
            }

            else if (p2Lost == true)
            {
                
                stopwatch.Stop();
                MessageBox.Show(player1.Name + " vinner!");
                lblWinner.Text = player1.Name + " vinner!";
                lblWinner.Visible = true;
                if (GameInfo.ConnectedToDatabase == true)
                {
                    players[1].lose = true;
                    players[0].win = true;
                    players[1].win = false;
                    players[0].lose = false;
                    game.Update(players);
                    game.UpdateTimeStamp();
                }
                
            }
           
            
        }

        private void tmrEndGame_Tick(object sender, EventArgs e)
        {
            endGame++;
            
            if (endGame == 6 && (p1Lost == true || p2Lost == true))
            {
                Startpage startpage = new Startpage();
                startpage.Show();

                this.Hide();
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


            //croppedPic = croppedPic.Clone(new Rectangle(100, 100, 1820, 980), System.Drawing.Imaging.PixelFormat.DontCare);



        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoCaptureDevice.Stop();
            Application.Exit();
        }
    }
}

