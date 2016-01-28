namespace ForkLift_Simulator_2015
{
    partial class Frm_Practice_Arena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Practice_Arena));
            this.Pic_Sprite = new System.Windows.Forms.PictureBox();
            this.Tmr_Move = new System.Windows.Forms.Timer(this.components);
            this.Pic_GameArea = new System.Windows.Forms.PictureBox();
            this.Pic_Totes = new System.Windows.Forms.PictureBox();
            this.Tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.Pic_Tote = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoIMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoILiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iWasExpectingHelpDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imReadyForFinalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pic_Bin = new System.Windows.Forms.PictureBox();
            this.Pic_Litter = new System.Windows.Forms.PictureBox();
            this.Ntfy_ForkliftSim = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Totes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tote)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Litter)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Sprite
            // 
            this.Pic_Sprite.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Sprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pic_Sprite.Image = global::ForkLift_Simulator_2015.Properties.Resources.GoingForward;
            this.Pic_Sprite.Location = new System.Drawing.Point(62, 203);
            this.Pic_Sprite.Name = "Pic_Sprite";
            this.Pic_Sprite.Size = new System.Drawing.Size(70, 55);
            this.Pic_Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Sprite.TabIndex = 1;
            this.Pic_Sprite.TabStop = false;
            // 
            // Tmr_Move
            // 
            this.Tmr_Move.Enabled = true;
            this.Tmr_Move.Interval = 1;
            this.Tmr_Move.Tick += new System.EventHandler(this.Tmr_Move_Tick);
            // 
            // Pic_GameArea
            // 
            this.Pic_GameArea.BackColor = System.Drawing.Color.Transparent;
            this.Pic_GameArea.Location = new System.Drawing.Point(43, 24);
            this.Pic_GameArea.Name = "Pic_GameArea";
            this.Pic_GameArea.Size = new System.Drawing.Size(788, 393);
            this.Pic_GameArea.TabIndex = 2;
            this.Pic_GameArea.TabStop = false;
            // 
            // Pic_Totes
            // 
            this.Pic_Totes.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Totes.Location = new System.Drawing.Point(354, 24);
            this.Pic_Totes.Name = "Pic_Totes";
            this.Pic_Totes.Size = new System.Drawing.Size(154, 393);
            this.Pic_Totes.TabIndex = 3;
            this.Pic_Totes.TabStop = false;
            // 
            // Tmr_Game
            // 
            this.Tmr_Game.Enabled = true;
            this.Tmr_Game.Interval = 1;
            this.Tmr_Game.Tick += new System.EventHandler(this.Tmr_Game_Tick);
            // 
            // Pic_Tote
            // 
            this.Pic_Tote.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Tote.Image = global::ForkLift_Simulator_2015.Properties.Resources.Tote;
            this.Pic_Tote.Location = new System.Drawing.Point(836, 364);
            this.Pic_Tote.Name = "Pic_Tote";
            this.Pic_Tote.Size = new System.Drawing.Size(26, 44);
            this.Pic_Tote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Tote.TabIndex = 4;
            this.Pic_Tote.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.imReadyForFinalsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howDoIMoveToolStripMenuItem,
            this.howDoILiftToolStripMenuItem,
            this.iWasExpectingHelpDocumentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Help!";
            // 
            // howDoIMoveToolStripMenuItem
            // 
            this.howDoIMoveToolStripMenuItem.Name = "howDoIMoveToolStripMenuItem";
            this.howDoIMoveToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.howDoIMoveToolStripMenuItem.Text = "How Do I Move?";
            this.howDoIMoveToolStripMenuItem.Click += new System.EventHandler(this.howDoIMoveToolStripMenuItem_Click);
            // 
            // howDoILiftToolStripMenuItem
            // 
            this.howDoILiftToolStripMenuItem.Name = "howDoILiftToolStripMenuItem";
            this.howDoILiftToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.howDoILiftToolStripMenuItem.Text = "How Do I Lift?";
            this.howDoILiftToolStripMenuItem.Click += new System.EventHandler(this.howDoILiftToolStripMenuItem_Click);
            // 
            // iWasExpectingHelpDocumentsToolStripMenuItem
            // 
            this.iWasExpectingHelpDocumentsToolStripMenuItem.Name = "iWasExpectingHelpDocumentsToolStripMenuItem";
            this.iWasExpectingHelpDocumentsToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.iWasExpectingHelpDocumentsToolStripMenuItem.Text = "I Was Expecting Help Documents";
            this.iWasExpectingHelpDocumentsToolStripMenuItem.Click += new System.EventHandler(this.iWasExpectingHelpDocumentsToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.videoToolStripMenuItem.Text = "Video Explanation";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // imReadyForFinalsToolStripMenuItem
            // 
            this.imReadyForFinalsToolStripMenuItem.Name = "imReadyForFinalsToolStripMenuItem";
            this.imReadyForFinalsToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.imReadyForFinalsToolStripMenuItem.Text = "I\'m Ready For Competition!";
            this.imReadyForFinalsToolStripMenuItem.Click += new System.EventHandler(this.imReadyForFinalsToolStripMenuItem_Click);
            // 
            // Pic_Bin
            // 
            this.Pic_Bin.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Bin.Image = global::ForkLift_Simulator_2015.Properties.Resources.Can;
            this.Pic_Bin.Location = new System.Drawing.Point(415, 270);
            this.Pic_Bin.Name = "Pic_Bin";
            this.Pic_Bin.Size = new System.Drawing.Size(31, 27);
            this.Pic_Bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Bin.TabIndex = 6;
            this.Pic_Bin.TabStop = false;
            // 
            // Pic_Litter
            // 
            this.Pic_Litter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Pic_Litter.Location = new System.Drawing.Point(607, 352);
            this.Pic_Litter.Name = "Pic_Litter";
            this.Pic_Litter.Size = new System.Drawing.Size(115, 10);
            this.Pic_Litter.TabIndex = 17;
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
            // Frm_Practice_Arena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ForkLift_Simulator_2015.Properties.Resources.PracticeField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 439);
            this.Controls.Add(this.Pic_Litter);
            this.Controls.Add(this.Pic_Bin);
            this.Controls.Add(this.Pic_Sprite);
            this.Controls.Add(this.Pic_Tote);
            this.Controls.Add(this.Pic_GameArea);
            this.Controls.Add(this.Pic_Totes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Practice_Arena";
            this.Text = "Practice Arena";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pit_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Practice_Arena_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frm_Practice_Arena_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_GameArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Totes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tote)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Bin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Litter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Sprite;
        private System.Windows.Forms.Timer Tmr_Move;
        private System.Windows.Forms.PictureBox Pic_GameArea;
        private System.Windows.Forms.PictureBox Pic_Totes;
        private System.Windows.Forms.Timer Tmr_Game;
        private System.Windows.Forms.PictureBox Pic_Tote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDoIMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDoILiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imReadyForFinalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iWasExpectingHelpDocumentsToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pic_Bin;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pic_Litter;
        private System.Windows.Forms.NotifyIcon Ntfy_ForkliftSim;
    }
}