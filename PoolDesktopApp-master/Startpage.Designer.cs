
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(92, 422);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(226, 115);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Quickgame";
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
            this.cboCamera.Location = new System.Drawing.Point(378, 345);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(226, 28);
            this.cboCamera.TabIndex = 47;
            // 
            // btnStartSim
            // 
            this.btnStartSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSim.Location = new System.Drawing.Point(378, 422);
            this.btnStartSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(226, 115);
            this.btnStartSim.TabIndex = 48;
            this.btnStartSim.Text = "Start Simulation";
            this.btnStartSim.UseVisualStyleBackColor = true;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(157, 108);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(533, 84);
            this.txtInfo.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pick camera";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(378, 239);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(226, 26);
            this.txtPlayer1.TabIndex = 55;
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(378, 274);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(226, 26);
            this.txtPlayer2.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Player 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Player 2:";
            // 
            // Startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInfo);
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
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}