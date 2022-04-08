
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startpage));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSolid = new System.Windows.Forms.RadioButton();
            this.rdoHalf = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(92, 422);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(226, 115);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cboCamera.Location = new System.Drawing.Point(387, 345);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(217, 28);
            this.cboCamera.TabIndex = 47;
            // 
            // btnStartSim
            // 
            this.btnStartSim.Location = new System.Drawing.Point(378, 422);
            this.btnStartSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(226, 115);
            this.btnStartSim.TabIndex = 48;
            this.btnStartSim.Text = "Start Simulation";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(92, 28);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(226, 85);
            this.btnConnect.TabIndex = 49;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(324, 28);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(366, 84);
            this.txtInfo.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Choose Player 1 ball type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pick camera";
            // 
            // rdoSolid
            // 
            this.rdoSolid.AutoSize = true;
            this.rdoSolid.Checked = true;
            this.rdoSolid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSolid.Location = new System.Drawing.Point(387, 292);
            this.rdoSolid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSolid.Name = "rdoSolid";
            this.rdoSolid.Size = new System.Drawing.Size(69, 24);
            this.rdoSolid.TabIndex = 53;
            this.rdoSolid.TabStop = true;
            this.rdoSolid.Text = "Solid";
            this.rdoSolid.UseVisualStyleBackColor = true;
            // 
            // rdoHalf
            // 
            this.rdoHalf.AutoSize = true;
            this.rdoHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHalf.Location = new System.Drawing.Point(542, 292);
            this.rdoHalf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoHalf.Name = "rdoHalf";
            this.rdoHalf.Size = new System.Drawing.Size(63, 24);
            this.rdoHalf.TabIndex = 54;
            this.rdoHalf.Text = "Half";
            this.rdoHalf.UseVisualStyleBackColor = true;
            // 
            // Startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 609);
            this.Controls.Add(this.rdoHalf);
            this.Controls.Add(this.rdoSolid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnStartSim);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btnStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Startpage";
            this.Text = "Startpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Startpage_FormClosed);
            this.Load += new System.EventHandler(this.Startpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        public System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSolid;
        private System.Windows.Forms.RadioButton rdoHalf;
    }
}