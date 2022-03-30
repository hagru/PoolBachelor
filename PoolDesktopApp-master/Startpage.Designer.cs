
namespace PoolDesktopApp
{
    partial class Startpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startpage));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectBall = new System.Windows.Forms.ComboBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(91, 307);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(227, 115);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtP1Name
            // 
            this.txtP1Name.Location = new System.Drawing.Point(91, 166);
            this.txtP1Name.Name = "txtP1Name";
            this.txtP1Name.Size = new System.Drawing.Size(236, 26);
            this.txtP1Name.TabIndex = 2;
            // 
            // txtP2Name
            // 
            this.txtP2Name.Location = new System.Drawing.Point(472, 166);
            this.txtP2Name.Name = "txtP2Name";
            this.txtP2Name.Size = new System.Drawing.Size(236, 26);
            this.txtP2Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player 1 name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2 name";
            // 
            // cboSelectBall
            // 
            this.cboSelectBall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectBall.FormattingEnabled = true;
            this.cboSelectBall.Items.AddRange(new object[] {
            "Solid",
            "Half"});
            this.cboSelectBall.Location = new System.Drawing.Point(91, 232);
            this.cboSelectBall.Name = "cboSelectBall";
            this.cboSelectBall.Size = new System.Drawing.Size(110, 28);
            this.cboSelectBall.TabIndex = 7;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cboCamera.Location = new System.Drawing.Point(587, 232);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(121, 28);
            this.cboCamera.TabIndex = 47;
            // 
            // btnStartSim
            // 
            this.btnStartSim.Location = new System.Drawing.Point(481, 307);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(227, 115);
            this.btnStartSim.TabIndex = 48;
            this.btnStartSim.Text = "Start Simulation";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(109, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 31);
            this.btnConnect.TabIndex = 49;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(387, 27);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(143, 84);
            this.txtInfo.TabIndex = 50;
            // 
            // Startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnStartSim);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.cboSelectBall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.btnStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startpage";
            this.Text = "Startpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Startpage_FormClosed);
            this.Load += new System.EventHandler(this.Startpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.ComboBox cboSelectBall;
        public System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtInfo;
    }
}