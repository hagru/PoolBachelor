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

namespace PoolDesktopApp
{
    public partial class Startpage : Form
    {
        // Deklarerer tomme variabler som skal fylles ut og sendes videre
        public static string p1Name = "";
        public static string p2Name = "";
        public static string ballTypeP1 = "";
        public static string ballTypeP2 = "";
        public static bool solidBall = false;
        public static bool halfBall = false;
        public static bool simulationMode = false;
        public static int selectedCamera = 0;
        public static FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice videoCaptureDevice;

        // Boolsk variabel for å sjekke om navn er oppgitt
        public bool nameOkay = false;

        public Startpage()
        {
            InitializeComponent();
            cboSelectBall.SelectedIndex = 0;
        }

        // Metode som setter navn
        public void SetName()
        {
            p1Name = txtP1Name.Text;
            p2Name = txtP2Name.Text;

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

        public void SetNameSim()
        {
            p1Name = txtP1Name.Text;
            p2Name = txtP2Name.Text;

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
            ballTypeP1 = cboSelectBall.Text;
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
            ballTypeP1 = cboSelectBall.Text;
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
        }

        private void Startpage_Load(object sender, EventArgs e)
        {
            cboCamera.Items.Clear();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboCamera.Items.Add(filter.Name);
            }
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
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
            GameConfig.DataReceived();
            int b = 4;

            //while (GameConfig.DataReceived() == true)
            //{
            //    txtInfo.Text += GameConfig.Username1 + " " + GameConfig.Username2;
            //}
           
            
        }
    }
}
