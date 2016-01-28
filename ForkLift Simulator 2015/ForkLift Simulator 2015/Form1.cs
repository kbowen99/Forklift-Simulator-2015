using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForkLift_Simulator_2015
{
    public partial class Frm_SceneSelector : Form
    {
        public Frm_SceneSelector()
        {
            //The Constructor!
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Absolutely Useless!
        }

        private void Btn_Simulation_Click(object sender, EventArgs e)
        {
            //Button that opens Practice Arena
            //Welcome Message
            MessageBox.Show("Welcome, to start you will be entered into a Practice Arena to get used to the controls","Welcome to Forklift Simulator 2015");
            using (Frm_Practice_Arena f2 = new Frm_Practice_Arena()) //Basically Initializes Practice arena as "f2"
            {
                this.Hide();//hides main form
                while (f2.ShowDialog() != DialogResult.OK) //until the second formreports a dialog result ok, open it as a dialogbox
                {
                    this.Enabled = false;
                }
                this.Enabled = true;
            }
        }
    }
    
}
