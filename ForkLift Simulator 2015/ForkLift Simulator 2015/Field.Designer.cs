namespace ForkLift_Simulator_2015
{
    partial class Frm_Field
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Field));
            this.Tmr_Move = new System.Windows.Forms.Timer(this.components);
            this.Pic_Sprite = new System.Windows.Forms.PictureBox();
            this.Tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.Pic_GameArea = new System.Windows.Forms.PictureBox();
            this.Pic_Tote = new System.Windows.Forms.PictureBox();
            this.Pic_Totes = new System.Windows.Forms.PictureBox();
            this.Lbl_BlueAlliance = new System.Windows.Forms.Label();
            this.Lbl_RedAlliance = new System.Windows.Forms.Label();
            this.Pic_Bin = new System.Windows.Forms.PictureBox();
            this.Lbl_Game = new System.Windows.Forms.Label();
            this.Pic_Scoring1 = new System.Windows.Forms.PictureBox();
            this.Pic_Scoring2 = new System.Windows.Forms.PictureBox();
            this.Btn_Restart = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Tmr_Time = new System.Windows.Forms.Timer(this.components);
            this.Tmr_BlueAlliance = new System.Windows.Forms.Timer(this.components);
            this.Pic_Litter = new System.Windows.Forms.PictureBox();
            this.Ntfy_ForkliftSim = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Totes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Scoring1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Scoring2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Litter)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr_Move
            // 
            this.Tmr_Move.Interval = 1;
            this.Tmr_Move.Tick += new System.EventHandler(this.Tmr_Move_Tick);
            // 
            // Pic_Sprite
            // 
            this.Pic_Sprite.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Sprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pic_Sprite.Image = global::ForkLift_Simulator_2015.Properties.Resources.GoingForward;
            this.Pic_Sprite.Location = new System.Drawing.Point(752, 202);
            this.Pic_Sprite.Name = "Pic_Sprite";
            this.Pic_Sprite.Size = new System.Drawing.Size(69, 55);
            this.Pic_Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Sprite.TabIndex = 2;
            this.Pic_Sprite.TabStop = false;
            this.Pic_Sprite.Click += new System.EventHandler(this.Pic_Sprite_Click);
            // 
            // Tmr_Game
            // 
            this.Tmr_Game.Interval = 1;
            this.Tmr_Game.Tick += new System.EventHandler(this.Tmr_Game_Tick);
            // 
            // Pic_GameArea
            // 
            this.Pic_GameArea.BackColor = System.Drawing.Color.Transparent;
            this.Pic_GameArea.Location = new System.Drawing.Point(416, 23);
            this.Pic_GameArea.Name = "Pic_GameArea";
            this.Pic_GameArea.Size = new System.Drawing.Size(405, 393);
            this.Pic_GameArea.TabIndex = 3;
            this.Pic_GameArea.TabStop = false;
            // 
            // Pic_Tote
            // 
            this.Pic_Tote.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Tote.Image = global::ForkLift_Simulator_2015.Properties.Resources.Tote;
            this.Pic_Tote.Location = new System.Drawing.Point(444, 23);
            this.Pic_Tote.Name = "Pic_Tote";
            this.Pic_Tote.Size = new System.Drawing.Size(26, 44);
            this.Pic_Tote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Tote.TabIndex = 5;
            this.Pic_Tote.TabStop = false;
            // 
            // Pic_Totes
            // 
            this.Pic_Totes.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Totes.Location = new System.Drawing.Point(354, 23);
            this.Pic_Totes.Name = "Pic_Totes";
            this.Pic_Totes.Size = new System.Drawing.Size(154, 393);
            this.Pic_Totes.TabIndex = 6;
            this.Pic_Totes.TabStop = false;
            // 
            // Lbl_BlueAlliance
            // 
            this.Lbl_BlueAlliance.AutoSize = true;
            this.Lbl_BlueAlliance.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_BlueAlliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BlueAlliance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_BlueAlliance.Location = new System.Drawing.Point(12, 9);
            this.Lbl_BlueAlliance.Name = "Lbl_BlueAlliance";
            this.Lbl_BlueAlliance.Size = new System.Drawing.Size(24, 25);
            this.Lbl_BlueAlliance.TabIndex = 7;
            this.Lbl_BlueAlliance.Text = "0";
            // 
            // Lbl_RedAlliance
            // 
            this.Lbl_RedAlliance.AutoSize = true;
            this.Lbl_RedAlliance.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RedAlliance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RedAlliance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_RedAlliance.Location = new System.Drawing.Point(826, 9);
            this.Lbl_RedAlliance.Name = "Lbl_RedAlliance";
            this.Lbl_RedAlliance.Size = new System.Drawing.Size(24, 25);
            this.Lbl_RedAlliance.TabIndex = 8;
            this.Lbl_RedAlliance.Text = "0";
            // 
            // Pic_Bin
            // 
            this.Pic_Bin.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Bin.Image = global::ForkLift_Simulator_2015.Properties.Resources.Can;
            this.Pic_Bin.Location = new System.Drawing.Point(416, 269);
            this.Pic_Bin.Name = "Pic_Bin";
            this.Pic_Bin.Size = new System.Drawing.Size(31, 26);
            this.Pic_Bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Bin.TabIndex = 9;
            this.Pic_Bin.TabStop = false;
            // 
            // Lbl_Game
            // 
            this.Lbl_Game.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Game.ForeColor = System.Drawing.Color.Cyan;
            this.Lbl_Game.Location = new System.Drawing.Point(256, 330);
            this.Lbl_Game.Name = "Lbl_Game";
            this.Lbl_Game.Size = new System.Drawing.Size(352, 86);
            this.Lbl_Game.TabIndex = 10;
            this.Lbl_Game.Text = "Welcome To Forklift Simulator 2015 Competition, To begin the match Click on your " +
    "Forklift";
            this.Lbl_Game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_Scoring1
            // 
            this.Pic_Scoring1.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Scoring1.Location = new System.Drawing.Point(652, -1);
            this.Pic_Scoring1.Name = "Pic_Scoring1";
            this.Pic_Scoring1.Size = new System.Drawing.Size(74, 258);
            this.Pic_Scoring1.TabIndex = 11;
            this.Pic_Scoring1.TabStop = false;
            // 
            // Pic_Scoring2
            // 
            this.Pic_Scoring2.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Scoring2.Location = new System.Drawing.Point(535, 183);
            this.Pic_Scoring2.Name = "Pic_Scoring2";
            this.Pic_Scoring2.Size = new System.Drawing.Size(43, 233);
            this.Pic_Scoring2.TabIndex = 12;
            this.Pic_Scoring2.TabStop = false;
            // 
            // Btn_Restart
            // 
            this.Btn_Restart.Location = new System.Drawing.Point(354, 167);
            this.Btn_Restart.Name = "Btn_Restart";
            this.Btn_Restart.Size = new System.Drawing.Size(154, 45);
            this.Btn_Restart.TabIndex = 13;
            this.Btn_Restart.Text = "Restart";
            this.Btn_Restart.UseVisualStyleBackColor = true;
            this.Btn_Restart.Visible = false;
            this.Btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(354, 218);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(154, 45);
            this.Btn_Quit.TabIndex = 14;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Visible = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.ForeColor = System.Drawing.Color.White;
            this.Lbl_Time.Location = new System.Drawing.Point(354, -1);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(154, 35);
            this.Lbl_Time.TabIndex = 15;
            this.Lbl_Time.Text = "0";
            this.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tmr_Time
            // 
            this.Tmr_Time.Interval = 1;
            this.Tmr_Time.Tick += new System.EventHandler(this.Tmr_Time_Tick);
            // 
            // Tmr_BlueAlliance
            // 
            this.Tmr_BlueAlliance.Interval = 300;
            this.Tmr_BlueAlliance.Tick += new System.EventHandler(this.Tmr_BlueAlliance_Tick);
            // 
            // Pic_Litter
            // 
            this.Pic_Litter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Pic_Litter.Location = new System.Drawing.Point(0, 0);
            this.Pic_Litter.Name = "Pic_Litter";
            this.Pic_Litter.Size = new System.Drawing.Size(115, 10);
            this.Pic_Litter.TabIndex = 16;
            this.Pic_Litter.TabStop = false;
            // 
            // Ntfy_ForkliftSim
            // 
            this.Ntfy_ForkliftSim.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.Ntfy_ForkliftSim.BalloonTipText = "Why are you reading this? You have a videogame opern";
            this.Ntfy_ForkliftSim.BalloonTipTitle = "Forklift Simulator 2015";
            this.Ntfy_ForkliftSim.Icon = ((System.Drawing.Icon)(resources.GetObject("Ntfy_ForkliftSim.Icon")));
            this.Ntfy_ForkliftSim.Text = "Forklift Simulator 2015";
            this.Ntfy_ForkliftSim.Visible = true;
            // 
            // Frm_Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ForkLift_Simulator_2015.Properties.Resources.Field;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(862, 439);
            this.Controls.Add(this.Pic_Litter);
            this.Controls.Add(this.Pic_Sprite);
            this.Controls.Add(this.Pic_Bin);
            this.Controls.Add(this.Pic_Tote);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_Restart);
            this.Controls.Add(this.Lbl_RedAlliance);
            this.Controls.Add(this.Lbl_BlueAlliance);
            this.Controls.Add(this.Lbl_Game);
            this.Controls.Add(this.Pic_Scoring2);
            this.Controls.Add(this.Pic_Scoring1);
            this.Controls.Add(this.Pic_GameArea);
            this.Controls.Add(this.Pic_Totes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Field";
            this.Text = "Field";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Field_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Field_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Field_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Totes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Scoring1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Scoring2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Litter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr_Move;
        private System.Windows.Forms.PictureBox Pic_Sprite;
        private System.Windows.Forms.Timer Tmr_Game;
        private System.Windows.Forms.PictureBox Pic_GameArea;
        private System.Windows.Forms.PictureBox Pic_Tote;
        private System.Windows.Forms.PictureBox Pic_Totes;
        private System.Windows.Forms.Label Lbl_BlueAlliance;
        private System.Windows.Forms.Label Lbl_RedAlliance;
        private System.Windows.Forms.PictureBox Pic_Bin;
        private System.Windows.Forms.Label Lbl_Game;
        private System.Windows.Forms.PictureBox Pic_Scoring1;
        private System.Windows.Forms.PictureBox Pic_Scoring2;
        private System.Windows.Forms.Button Btn_Restart;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Timer Tmr_Time;
        private System.Windows.Forms.Timer Tmr_BlueAlliance;
        private System.Windows.Forms.PictureBox Pic_Litter;
        private System.Windows.Forms.NotifyIcon Ntfy_ForkliftSim;
    }
}