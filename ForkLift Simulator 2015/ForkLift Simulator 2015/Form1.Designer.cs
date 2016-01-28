namespace ForkLift_Simulator_2015
{
    partial class Frm_SceneSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SceneSelector));
            this.Pic_RecycleRush = new System.Windows.Forms.PictureBox();
            this.Pic_FIRSTLogo = new System.Windows.Forms.PictureBox();
            this.Btn_Simulation = new System.Windows.Forms.Button();
            this.Ntfy_ForkliftSim = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_RecycleRush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FIRSTLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_RecycleRush
            // 
            this.Pic_RecycleRush.BackColor = System.Drawing.Color.Transparent;
            this.Pic_RecycleRush.BackgroundImage = global::ForkLift_Simulator_2015.Properties.Resources.RecycleRush;
            this.Pic_RecycleRush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_RecycleRush.Image = global::ForkLift_Simulator_2015.Properties.Resources.RecycleRush;
            this.Pic_RecycleRush.Location = new System.Drawing.Point(12, 12);
            this.Pic_RecycleRush.Name = "Pic_RecycleRush";
            this.Pic_RecycleRush.Size = new System.Drawing.Size(142, 83);
            this.Pic_RecycleRush.TabIndex = 1;
            this.Pic_RecycleRush.TabStop = false;
            // 
            // Pic_FIRSTLogo
            // 
            this.Pic_FIRSTLogo.BackColor = System.Drawing.Color.Transparent;
            this.Pic_FIRSTLogo.BackgroundImage = global::ForkLift_Simulator_2015.Properties.Resources.FIRST;
            this.Pic_FIRSTLogo.Image = global::ForkLift_Simulator_2015.Properties.Resources.FIRST;
            this.Pic_FIRSTLogo.Location = new System.Drawing.Point(12, 323);
            this.Pic_FIRSTLogo.Name = "Pic_FIRSTLogo";
            this.Pic_FIRSTLogo.Size = new System.Drawing.Size(189, 64);
            this.Pic_FIRSTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_FIRSTLogo.TabIndex = 2;
            this.Pic_FIRSTLogo.TabStop = false;
            // 
            // Btn_Simulation
            // 
            this.Btn_Simulation.Location = new System.Drawing.Point(326, 258);
            this.Btn_Simulation.Name = "Btn_Simulation";
            this.Btn_Simulation.Size = new System.Drawing.Size(163, 45);
            this.Btn_Simulation.TabIndex = 3;
            this.Btn_Simulation.Text = "Enter The Simulation";
            this.Btn_Simulation.UseVisualStyleBackColor = true;
            this.Btn_Simulation.Click += new System.EventHandler(this.Btn_Simulation_Click);
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
            // Frm_SceneSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ForkLift_Simulator_2015.Properties.Resources.FRC2015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 399);
            this.Controls.Add(this.Btn_Simulation);
            this.Controls.Add(this.Pic_FIRSTLogo);
            this.Controls.Add(this.Pic_RecycleRush);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_SceneSelector";
            this.Text = "Forklift Simulator 2015";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_RecycleRush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_FIRSTLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_RecycleRush;
        private System.Windows.Forms.PictureBox Pic_FIRSTLogo;
        private System.Windows.Forms.Button Btn_Simulation;
        private System.Windows.Forms.NotifyIcon Ntfy_ForkliftSim;
    }
}

