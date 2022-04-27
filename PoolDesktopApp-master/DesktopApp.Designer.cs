
namespace PoolDesktopApp
{
    partial class DesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopApp));
            this.pBoxMainGame = new System.Windows.Forms.PictureBox();
            this.pBoxCueP1 = new System.Windows.Forms.PictureBox();
            this.pBoxCueP2 = new System.Windows.Forms.PictureBox();
            this.p1Ball1 = new System.Windows.Forms.PictureBox();
            this.p1Ball2 = new System.Windows.Forms.PictureBox();
            this.p1Ball3 = new System.Windows.Forms.PictureBox();
            this.p1Ball4 = new System.Windows.Forms.PictureBox();
            this.p1Ball5 = new System.Windows.Forms.PictureBox();
            this.p1Ball6 = new System.Windows.Forms.PictureBox();
            this.p1Ball7 = new System.Windows.Forms.PictureBox();
            this.p2Ball7 = new System.Windows.Forms.PictureBox();
            this.p2Ball6 = new System.Windows.Forms.PictureBox();
            this.p2Ball5 = new System.Windows.Forms.PictureBox();
            this.p2Ball4 = new System.Windows.Forms.PictureBox();
            this.p2Ball3 = new System.Windows.Forms.PictureBox();
            this.p2Ball2 = new System.Windows.Forms.PictureBox();
            this.p2Ball1 = new System.Windows.Forms.PictureBox();
            this.p1Ball8 = new System.Windows.Forms.PictureBox();
            this.p2Ball8 = new System.Windows.Forms.PictureBox();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.pboLoading = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblGameId = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.tmrEndGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball8)).BeginInit();
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
            this.pBoxMainGame.TabIndex = 0;
            this.pBoxMainGame.TabStop = false;
            // 
            // pBoxCueP1
            // 
            this.pBoxCueP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBoxCueP1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCueP1.Image")));
            this.pBoxCueP1.Location = new System.Drawing.Point(333, 1215);
            this.pBoxCueP1.Name = "pBoxCueP1";
            this.pBoxCueP1.Size = new System.Drawing.Size(649, 73);
            this.pBoxCueP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCueP1.TabIndex = 5;
            this.pBoxCueP1.TabStop = false;
            this.pBoxCueP1.Visible = false;
            // 
            // pBoxCueP2
            // 
            this.pBoxCueP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxCueP2.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCueP2.Image")));
            this.pBoxCueP2.Location = new System.Drawing.Point(1579, 1215);
            this.pBoxCueP2.Name = "pBoxCueP2";
            this.pBoxCueP2.Size = new System.Drawing.Size(649, 73);
            this.pBoxCueP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCueP2.TabIndex = 6;
            this.pBoxCueP2.TabStop = false;
            this.pBoxCueP2.Visible = false;
            // 
            // p1Ball1
            // 
            this.p1Ball1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball1.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball1.Image")));
            this.p1Ball1.Location = new System.Drawing.Point(71, 1300);
            this.p1Ball1.Name = "p1Ball1";
            this.p1Ball1.Size = new System.Drawing.Size(125, 125);
            this.p1Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball1.TabIndex = 7;
            this.p1Ball1.TabStop = false;
            this.p1Ball1.Visible = false;
            // 
            // p1Ball2
            // 
            this.p1Ball2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball2.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball2.Image")));
            this.p1Ball2.Location = new System.Drawing.Point(202, 1300);
            this.p1Ball2.Name = "p1Ball2";
            this.p1Ball2.Size = new System.Drawing.Size(125, 125);
            this.p1Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball2.TabIndex = 8;
            this.p1Ball2.TabStop = false;
            this.p1Ball2.Visible = false;
            // 
            // p1Ball3
            // 
            this.p1Ball3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball3.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball3.Image")));
            this.p1Ball3.Location = new System.Drawing.Point(333, 1300);
            this.p1Ball3.Name = "p1Ball3";
            this.p1Ball3.Size = new System.Drawing.Size(125, 125);
            this.p1Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball3.TabIndex = 9;
            this.p1Ball3.TabStop = false;
            this.p1Ball3.Visible = false;
            // 
            // p1Ball4
            // 
            this.p1Ball4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball4.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball4.Image")));
            this.p1Ball4.Location = new System.Drawing.Point(464, 1300);
            this.p1Ball4.Name = "p1Ball4";
            this.p1Ball4.Size = new System.Drawing.Size(125, 125);
            this.p1Ball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball4.TabIndex = 10;
            this.p1Ball4.TabStop = false;
            this.p1Ball4.Visible = false;
            // 
            // p1Ball5
            // 
            this.p1Ball5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball5.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball5.Image")));
            this.p1Ball5.Location = new System.Drawing.Point(595, 1300);
            this.p1Ball5.Name = "p1Ball5";
            this.p1Ball5.Size = new System.Drawing.Size(125, 125);
            this.p1Ball5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball5.TabIndex = 11;
            this.p1Ball5.TabStop = false;
            this.p1Ball5.Visible = false;
            // 
            // p1Ball6
            // 
            this.p1Ball6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball6.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball6.Image")));
            this.p1Ball6.Location = new System.Drawing.Point(726, 1300);
            this.p1Ball6.Name = "p1Ball6";
            this.p1Ball6.Size = new System.Drawing.Size(125, 125);
            this.p1Ball6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball6.TabIndex = 12;
            this.p1Ball6.TabStop = false;
            this.p1Ball6.Visible = false;
            // 
            // p1Ball7
            // 
            this.p1Ball7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball7.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball7.Image")));
            this.p1Ball7.Location = new System.Drawing.Point(857, 1300);
            this.p1Ball7.Name = "p1Ball7";
            this.p1Ball7.Size = new System.Drawing.Size(125, 125);
            this.p1Ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball7.TabIndex = 13;
            this.p1Ball7.TabStop = false;
            this.p1Ball7.Visible = false;
            // 
            // p2Ball7
            // 
            this.p2Ball7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball7.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball7.Image")));
            this.p2Ball7.Location = new System.Drawing.Point(2365, 1300);
            this.p2Ball7.Name = "p2Ball7";
            this.p2Ball7.Size = new System.Drawing.Size(125, 125);
            this.p2Ball7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball7.TabIndex = 20;
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
            this.p2Ball6.TabIndex = 19;
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
            this.p2Ball5.TabIndex = 18;
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
            this.p2Ball4.TabIndex = 17;
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
            this.p2Ball3.TabIndex = 16;
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
            this.p2Ball2.TabIndex = 15;
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
            this.p2Ball1.TabIndex = 14;
            this.p2Ball1.TabStop = false;
            this.p2Ball1.Visible = false;
            // 
            // p1Ball8
            // 
            this.p1Ball8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p1Ball8.Image = ((System.Drawing.Image)(resources.GetObject("p1Ball8.Image")));
            this.p1Ball8.Location = new System.Drawing.Point(988, 1300);
            this.p1Ball8.Name = "p1Ball8";
            this.p1Ball8.Size = new System.Drawing.Size(125, 125);
            this.p1Ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Ball8.TabIndex = 37;
            this.p1Ball8.TabStop = false;
            this.p1Ball8.Visible = false;
            // 
            // p2Ball8
            // 
            this.p2Ball8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Ball8.Image = ((System.Drawing.Image)(resources.GetObject("p2Ball8.Image")));
            this.p2Ball8.Location = new System.Drawing.Point(1448, 1300);
            this.p2Ball8.Name = "p2Ball8";
            this.p2Ball8.Size = new System.Drawing.Size(125, 125);
            this.p2Ball8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Ball8.TabIndex = 38;
            this.p2Ball8.TabStop = false;
            this.p2Ball8.Visible = false;
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Enabled = true;
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 1469);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(2564, 101);
            this.lblTimer.TabIndex = 44;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblP2
            // 
            this.lblP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(2226, 1222);
            this.lblP2.Name = "lblP2";
            this.lblP2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblP2.Size = new System.Drawing.Size(330, 75);
            this.lblP2.TabIndex = 45;
            this.lblP2.Text = "Player 2";
            this.lblP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblP1
            // 
            this.lblP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(0, 1222);
            this.lblP1.Name = "lblP1";
            this.lblP1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblP1.Size = new System.Drawing.Size(330, 75);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "Player 1";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pboLoading
            // 
            this.pboLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pboLoading.BackColor = System.Drawing.Color.Transparent;
            this.pboLoading.Enabled = false;
            this.pboLoading.Location = new System.Drawing.Point(1084, 1300);
            this.pboLoading.Name = "pboLoading";
            this.pboLoading.Size = new System.Drawing.Size(83, 83);
            this.pboLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLoading.TabIndex = 70;
            this.pboLoading.TabStop = false;
            this.pboLoading.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblGameId
            // 
            this.lblGameId.AutoSize = true;
            this.lblGameId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameId.Location = new System.Drawing.Point(31, 111);
            this.lblGameId.Name = "lblGameId";
            this.lblGameId.Size = new System.Drawing.Size(100, 25);
            this.lblGameId.TabIndex = 71;
            this.lblGameId.Text = "Game ID: ";
            // 
            // lblWinner
            // 
            this.lblWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(1032, 1239);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(184, 58);
            this.lblWinner.TabIndex = 72;
            this.lblWinner.Text = "Winner";
            this.lblWinner.Visible = false;
            // 
            // tmrEndGame
            // 
            this.tmrEndGame.Interval = 1000;
            this.tmrEndGame.Tick += new System.EventHandler(this.tmrEndGame_Tick);
            // 
            // DesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2564, 1570);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pboLoading);
            this.Controls.Add(this.lblGameId);
            this.Controls.Add(this.p1Ball8);
            this.Controls.Add(this.p1Ball7);
            this.Controls.Add(this.p1Ball6);
            this.Controls.Add(this.p1Ball5);
            this.Controls.Add(this.p1Ball4);
            this.Controls.Add(this.p1Ball3);
            this.Controls.Add(this.p1Ball2);
            this.Controls.Add(this.p1Ball1);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.pBoxCueP1);
            this.Controls.Add(this.p2Ball8);
            this.Controls.Add(this.p2Ball7);
            this.Controls.Add(this.p2Ball6);
            this.Controls.Add(this.p2Ball5);
            this.Controls.Add(this.p2Ball4);
            this.Controls.Add(this.p2Ball3);
            this.Controls.Add(this.p2Ball2);
            this.Controls.Add(this.p2Ball1);
            this.Controls.Add(this.pBoxCueP2);
            this.Controls.Add(this.pBoxMainGame);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesktopApp";
            this.Text = "Pool desktop application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.DesktopApp_Activated);
            this.Deactivate += new System.EventHandler(this.DesktopApp_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DesktopApp_FormClosed);
            this.Load += new System.EventHandler(this.DesktopApp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesktopApp_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMainGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCueP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Ball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxMainGame;
        private System.Windows.Forms.PictureBox pBoxCueP1;
        private System.Windows.Forms.PictureBox pBoxCueP2;
        private System.Windows.Forms.PictureBox p1Ball1;
        private System.Windows.Forms.PictureBox p1Ball2;
        private System.Windows.Forms.PictureBox p1Ball3;
        private System.Windows.Forms.PictureBox p1Ball4;
        private System.Windows.Forms.PictureBox p1Ball5;
        private System.Windows.Forms.PictureBox p1Ball6;
        private System.Windows.Forms.PictureBox p1Ball7;
        private System.Windows.Forms.PictureBox p2Ball7;
        private System.Windows.Forms.PictureBox p2Ball6;
        private System.Windows.Forms.PictureBox p2Ball5;
        private System.Windows.Forms.PictureBox p2Ball4;
        private System.Windows.Forms.PictureBox p2Ball3;
        private System.Windows.Forms.PictureBox p2Ball2;
        private System.Windows.Forms.PictureBox p2Ball1;
        private System.Windows.Forms.PictureBox p1Ball8;
        private System.Windows.Forms.PictureBox p2Ball8;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.PictureBox pboLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblGameId;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Timer tmrEndGame;
    }
}
