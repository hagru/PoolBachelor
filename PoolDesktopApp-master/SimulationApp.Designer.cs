
namespace PoolDesktopApp
{
    partial class SimulationApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationApp));
            this.pBoxMainGame = new System.Windows.Forms.PictureBox();
            this.lblP2 = new System.Windows.Forms.Label();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.p2Ball8 = new System.Windows.Forms.PictureBox();
            this.p1Ball8 = new System.Windows.Forms.PictureBox();
            this.p2Ball7 = new System.Windows.Forms.PictureBox();
            this.p2Ball6 = new System.Windows.Forms.PictureBox();
            this.p2Ball5 = new System.Windows.Forms.PictureBox();
            this.p2Ball4 = new System.Windows.Forms.PictureBox();
            this.p2Ball3 = new System.Windows.Forms.PictureBox();
            this.p2Ball2 = new System.Windows.Forms.PictureBox();
            this.p2Ball1 = new System.Windows.Forms.PictureBox();
            this.p1Ball7 = new System.Windows.Forms.PictureBox();
            this.p1Ball6 = new System.Windows.Forms.PictureBox();
            this.p1Ball5 = new System.Windows.Forms.PictureBox();
            this.p1Ball4 = new System.Windows.Forms.PictureBox();
            this.p1Ball3 = new System.Windows.Forms.PictureBox();
            this.p1Ball2 = new System.Windows.Forms.PictureBox();
            this.p1Ball1 = new System.Windows.Forms.PictureBox();
            this.pBoxCueP2 = new System.Windows.Forms.PictureBox();
            this.pBoxCueP1 = new System.Windows.Forms.PictureBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pboLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxMainGame
            // 
            this.pBoxMainGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxMainGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxMainGame.Location = new System.Drawing.Point(333, 12);
            this.pBoxMainGame.Name = "pBoxMainGame";
            this.pBoxMainGame.Size = new System.Drawing.Size(1895, 1197);
            this.pBoxMainGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMainGame.TabIndex = 46;
            this.pBoxMainGame.TabStop = false;
            // 
            // lblP2
            // 
            this.lblP2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(2234, 0);
            this.lblP2.Name = "lblP2";
            this.lblP2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblP2.Size = new System.Drawing.Size(330, 1300);
            this.lblP2.TabIndex = 68;
            this.lblP2.Text = "Player 2";
            this.lblP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Enabled = true;
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // p2Ball8
            // 
            this.p2Ball8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball8.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball8.Image")));
            this.p2Ball8.Location = new System.Drawing.Point(1448, 1300);
            this.p2Ball8.Name = "p2Ball8";
            this.p2Ball8.Size = new System.Drawing.Size(125, 125);
            this.p2Ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball8.TabIndex = 66;
            this.p2Ball8.TabStop = false;
            this.p2Ball8.Visible = false;
            // 
            // p1Ball8
            // 
            this.p1Ball8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball8.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball8.Image")));
            this.p1Ball8.Location = new System.Drawing.Point(988, 1300);
            this.p1Ball8.Name = "p1Ball8";
            this.p1Ball8.Size = new System.Drawing.Size(125, 125);
            this.p1Ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball8.TabIndex = 65;
            this.p1Ball8.TabStop = false;
            this.p1Ball8.Visible = false;
            // 
            // p2Ball7
            // 
            this.p2Ball7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball7.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball7.Image")));
            this.p2Ball7.Location = new System.Drawing.Point(2365, 1300);
            this.p2Ball7.Name = "p2Ball7";
            this.p2Ball7.Size = new System.Drawing.Size(125, 125);
            this.p2Ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball7.TabIndex = 63;
            this.p2Ball7.TabStop = false;
            this.p2Ball7.Visible = false;
            // 
            // p2Ball6
            // 
            this.p2Ball6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball6.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball6.Image")));
            this.p2Ball6.Location = new System.Drawing.Point(2234, 1300);
            this.p2Ball6.Name = "p2Ball6";
            this.p2Ball6.Size = new System.Drawing.Size(125, 125);
            this.p2Ball6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball6.TabIndex = 62;
            this.p2Ball6.TabStop = false;
            this.p2Ball6.Visible = false;
            // 
            // p2Ball5
            // 
            this.p2Ball5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball5.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball5.Image")));
            this.p2Ball5.Location = new System.Drawing.Point(2103, 1300);
            this.p2Ball5.Name = "p2Ball5";
            this.p2Ball5.Size = new System.Drawing.Size(125, 125);
            this.p2Ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball5.TabIndex = 61;
            this.p2Ball5.TabStop = false;
            this.p2Ball5.Visible = false;
            // 
            // p2Ball4
            // 
            this.p2Ball4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball4.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball4.Image")));
            this.p2Ball4.Location = new System.Drawing.Point(1972, 1300);
            this.p2Ball4.Name = "p2Ball4";
            this.p2Ball4.Size = new System.Drawing.Size(125, 125);
            this.p2Ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball4.TabIndex = 60;
            this.p2Ball4.TabStop = false;
            this.p2Ball4.Visible = false;
            // 
            // p2Ball3
            // 
            this.p2Ball3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball3.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball3.Image")));
            this.p2Ball3.Location = new System.Drawing.Point(1841, 1300);
            this.p2Ball3.Name = "p2Ball3";
            this.p2Ball3.Size = new System.Drawing.Size(125, 125);
            this.p2Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball3.TabIndex = 59;
            this.p2Ball3.TabStop = false;
            this.p2Ball3.Visible = false;
            // 
            // p2Ball2
            // 
            this.p2Ball2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball2.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball2.Image")));
            this.p2Ball2.Location = new System.Drawing.Point(1710, 1300);
            this.p2Ball2.Name = "p2Ball2";
            this.p2Ball2.Size = new System.Drawing.Size(125, 125);
            this.p2Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball2.TabIndex = 58;
            this.p2Ball2.TabStop = false;
            this.p2Ball2.Visible = false;
            // 
            // p2Ball1
            // 
            this.p2Ball1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball1.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball1.Image")));
            this.p2Ball1.Location = new System.Drawing.Point(1579, 1300);
            this.p2Ball1.Name = "p2Ball1";
            this.p2Ball1.Size = new System.Drawing.Size(125, 125);
            this.p2Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball1.TabIndex = 57;
            this.p2Ball1.TabStop = false;
            this.p2Ball1.Visible = false;
            // 
            // p1Ball7
            // 
            this.p1Ball7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball7.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball7.Image")));
            this.p1Ball7.Location = new System.Drawing.Point(857, 1300);
            this.p1Ball7.Name = "p1Ball7";
            this.p1Ball7.Size = new System.Drawing.Size(125, 125);
            this.p1Ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball7.TabIndex = 56;
            this.p1Ball7.TabStop = false;
            this.p1Ball7.Visible = false;
            // 
            // p1Ball6
            // 
            this.p1Ball6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball6.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball6.Image")));
            this.p1Ball6.Location = new System.Drawing.Point(726, 1300);
            this.p1Ball6.Name = "p1Ball6";
            this.p1Ball6.Size = new System.Drawing.Size(125, 125);
            this.p1Ball6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball6.TabIndex = 55;
            this.p1Ball6.TabStop = false;
            this.p1Ball6.Visible = false;
            // 
            // p1Ball5
            // 
            this.p1Ball5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball5.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball5.Image")));
            this.p1Ball5.Location = new System.Drawing.Point(595, 1300);
            this.p1Ball5.Name = "p1Ball5";
            this.p1Ball5.Size = new System.Drawing.Size(125, 125);
            this.p1Ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball5.TabIndex = 54;
            this.p1Ball5.TabStop = false;
            this.p1Ball5.Visible = false;
            // 
            // p1Ball4
            // 
            this.p1Ball4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball4.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball4.Image")));
            this.p1Ball4.Location = new System.Drawing.Point(464, 1300);
            this.p1Ball4.Name = "p1Ball4";
            this.p1Ball4.Size = new System.Drawing.Size(125, 125);
            this.p1Ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball4.TabIndex = 53;
            this.p1Ball4.TabStop = false;
            this.p1Ball4.Visible = false;
            // 
            // p1Ball3
            // 
            this.p1Ball3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball3.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball3.Image")));
            this.p1Ball3.Location = new System.Drawing.Point(333, 1300);
            this.p1Ball3.Name = "p1Ball3";
            this.p1Ball3.Size = new System.Drawing.Size(125, 125);
            this.p1Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball3.TabIndex = 52;
            this.p1Ball3.TabStop = false;
            this.p1Ball3.Visible = false;
            // 
            // p1Ball2
            // 
            this.p1Ball2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball2.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball2.Image")));
            this.p1Ball2.Location = new System.Drawing.Point(202, 1300);
            this.p1Ball2.Name = "p1Ball2";
            this.p1Ball2.Size = new System.Drawing.Size(125, 125);
            this.p1Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball2.TabIndex = 51;
            this.p1Ball2.TabStop = false;
            this.p1Ball2.Visible = false;
            // 
            // p1Ball1
            // 
            this.p1Ball1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball1.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball1.Image")));
            this.p1Ball1.Location = new System.Drawing.Point(71, 1300);
            this.p1Ball1.Name = "p1Ball1";
            this.p1Ball1.Size = new System.Drawing.Size(125, 125);
            this.p1Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball1.TabIndex = 50;
            this.p1Ball1.TabStop = false;
            this.p1Ball1.Visible = false;
            // 
            // pBoxCueP2
            // 
            this.pBoxCueP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxCueP2.Location = new System.Drawing.Point(1579, 1215);
            this.pBoxCueP2.Name = "pBoxCueP2";
            this.pBoxCueP2.Size = new System.Drawing.Size(649, 73);
            this.pBoxCueP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCueP2.TabIndex = 49;
            this.pBoxCueP2.TabStop = false;
            // 
            // pBoxCueP1
            // 
            this.pBoxCueP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBoxCueP1.Location = new System.Drawing.Point(333, 1215);
            this.pBoxCueP1.Name = "pBoxCueP1";
            this.pBoxCueP1.Size = new System.Drawing.Size(649, 73);
            this.pBoxCueP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCueP1.TabIndex = 48;
            this.pBoxCueP1.TabStop = false;
            // 
            // lblP1
            // 
            this.lblP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(0, 0);
            this.lblP1.Name = "lblP1";
            this.lblP1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblP1.Size = new System.Drawing.Size(327, 1300);
            this.lblP1.TabIndex = 47;
            this.lblP1.Text = "Player 1";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 1300);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(2564, 270);
            this.lblTimer.TabIndex = 67;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboLoading
            // 
            this.pboLoading.BackColor = System.Drawing.Color.Transparent;
            this.pboLoading.Enabled = false;
            this.pboLoading.Image = ((System.Drawing.Image)(resources.GetObject("pboLoading.Image")));
            this.pboLoading.Location = new System.Drawing.Point(1084, 1300);
            this.pboLoading.Name = "pboLoading";
            this.pboLoading.Size = new System.Drawing.Size(83, 83);
            this.pboLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLoading.TabIndex = 69;
            this.pboLoading.TabStop = false;
            this.pboLoading.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // SimulationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2564, 1570);
            this.Controls.Add(this.pboLoading);
            this.Controls.Add(this.pBoxMainGame);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.p2Ball8);
            this.Controls.Add(this.p1Ball8);
            this.Controls.Add(this.p2Ball7);
            this.Controls.Add(this.p2Ball6);
            this.Controls.Add(this.p2Ball5);
            this.Controls.Add(this.p2Ball4);
            this.Controls.Add(this.p2Ball3);
            this.Controls.Add(this.p2Ball2);
            this.Controls.Add(this.p2Ball1);
            this.Controls.Add(this.p1Ball7);
            this.Controls.Add(this.p1Ball6);
            this.Controls.Add(this.p1Ball5);
            this.Controls.Add(this.p1Ball4);
            this.Controls.Add(this.p1Ball3);
            this.Controls.Add(this.p1Ball2);
            this.Controls.Add(this.p1Ball1);
            this.Controls.Add(this.pBoxCueP2);
            this.Controls.Add(this.pBoxCueP1);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulationApp";
            this.Text = "SimulationApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationApp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxMainGame;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.PictureBox p2Ball8;
        private System.Windows.Forms.PictureBox p1Ball8;
        private System.Windows.Forms.PictureBox p2Ball7;
        private System.Windows.Forms.PictureBox p2Ball6;
        private System.Windows.Forms.PictureBox p2Ball5;
        private System.Windows.Forms.PictureBox p2Ball4;
        private System.Windows.Forms.PictureBox p2Ball3;
        private System.Windows.Forms.PictureBox p2Ball2;
        private System.Windows.Forms.PictureBox p2Ball1;
        private System.Windows.Forms.PictureBox p1Ball7;
        private System.Windows.Forms.PictureBox p1Ball6;
        private System.Windows.Forms.PictureBox p1Ball5;
        private System.Windows.Forms.PictureBox p1Ball4;
        private System.Windows.Forms.PictureBox p1Ball3;
        private System.Windows.Forms.PictureBox p1Ball2;
        private System.Windows.Forms.PictureBox p1Ball1;
        private System.Windows.Forms.PictureBox pBoxCueP2;
        private System.Windows.Forms.PictureBox pBoxCueP1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pboLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}