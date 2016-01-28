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
    public partial class Frm_Practice_Arena : Form //also serves to test code for final field
    {
        const int speed = 2; //For Paddles
        bool[] LeftRight = new bool[2]; //Forklift control
        bool[] UpDown = new bool[2];
        bool lifting = false;
        int ForkDirection = 1;
        //1 = Forward
        //2 = Right
        //3 = Backward
        //4 = Left
        int carrying = 1;
        //1 = tote
        //2 = bin
        Random rndGen = new Random();
        public Frm_Practice_Arena()
        {
            InitializeComponent(); //you know what this is
        }

        private void Pit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sends Dialog Ok to allow form closing
            this.DialogResult = DialogResult.OK;
            Application.Exit();
        }
        private void Frm_Practice_Arena_KeyDown(object sender, KeyEventArgs e)
        {
            //key controls
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.A)//left
                LeftRight[0] = true;
            else if (keyCode == Keys.D)//right
                LeftRight[1] = true;
            else if (keyCode == Keys.W)//up
                UpDown[0] = true;
            else if (keyCode == Keys.S)//down
                UpDown[1] = true;
            else if (keyCode == Keys.Space)//lift
            {
                Lift();
                Update_Image_Lift();
            }
        }

        private void Frm_Practice_Arena_KeyUp(object sender, KeyEventArgs e)
        {
            //KeyDown releasing
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.A)//left
            {
                LeftRight[0] = false;
                ForkDirection = 4;
            }
            else if (keyCode == Keys.D)//right
            {
                LeftRight[1] = false;
                ForkDirection = 2;
            }
            else if (keyCode == Keys.W)//up
            {
                UpDown[0] = false;
                ForkDirection = 1;
            }
            else if (keyCode == Keys.S)//down
            {
                UpDown[1] = false;
                ForkDirection = 3;
            }
        }

        public void Tmr_Move_Tick(object sender, EventArgs e)
        {
            // Moves the Player
            if (LeftRight[0])
            {
                Pic_Sprite.Left -= speed;
                if (lifting == false) //Checks to see which sprite is used
                {
                    Pic_Sprite.Image = Properties.Resources.GoingLeft;
                }
                else if (lifting == true) //Checks to see which sprite is used
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingLeft;
                }
            }
            if (LeftRight[1])
            {
                Pic_Sprite.Left += speed;
                if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingRight;
                }
                else if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingRight;
                }
            }
            if (UpDown[0])
            {
                Pic_Sprite.Top -= speed;
                if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingForward;
                }
                else if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingForward;
                }
            }
            if (UpDown[1])
            {
                Pic_Sprite.Top += speed;
                if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingBackward;
                } else if (lifting == true) {
                    Pic_Sprite.Image = Properties.Resources.LiftingBackward;
                }

            }
        }

        private void Tmr_Game_Tick(object sender, EventArgs e)
        {
            StayInField();
            //Has More Purpose in full game
        }
        private void StayInField() //Seperated for organization
        {
            //Checks that the palyer is within the bounding box
            if (Pic_Sprite.Left < Pic_GameArea.Left)//left side
            {
                Pic_Sprite.Left = Pic_GameArea.Left;
            }
            if (Pic_Sprite.Right > Pic_GameArea.Right)//right side
            {
                Pic_Sprite.Left = Pic_GameArea.Right - 69;
            }
            if (Pic_Sprite.Top < Pic_GameArea.Top)//top
            {
                Pic_Sprite.Top = Pic_GameArea.Top;
            }
            if (Pic_Sprite.Bottom > Pic_GameArea.Bottom)//bottom
            {
                Pic_Sprite.Top = Pic_Sprite.Top - 2;
            }
        }
        public void Lift() //lift /dispose
        {
            if (lifting == true) //dispose
            {
                lifting = false;
                Update_Image_Lift();
                //1 = Forward
                //2 = Right
                //3 = Backward
                //4 = Left
                if (carrying == 1)//if carrying a tote
                {
                    if (ForkDirection == 2)//which way you carry the tote
                    {
                        Pic_Tote.Left = Pic_Sprite.Right; //offset it from the forklift to line up with tongs
                        Pic_Tote.Top = Pic_Sprite.Top;
                        Pic_Tote.Visible = true; //make it visible
                    }
                    else if (ForkDirection == 1)
                    {
                        Pic_Tote.Left = Pic_Sprite.Left + 22;
                        Pic_Tote.Top = Pic_Sprite.Top + 44;
                        Pic_Tote.Top = (Pic_Sprite.Top - Pic_Tote.Height);
                        Pic_Tote.Visible = true;
                    }
                    else if (ForkDirection == 4)
                    {
                        Pic_Tote.Left = Pic_Sprite.Left - 15;
                        Pic_Tote.Top = Pic_Sprite.Top;
                        Pic_Tote.Visible = true;
                    }
                    else if (ForkDirection == 3)
                    {
                        Pic_Tote.Left = Pic_Sprite.Left + 22;
                        Pic_Tote.Top = Pic_Sprite.Bottom;
                        Pic_Tote.Visible = true;
                    }
                }
                else if (carrying == 2) //bins
                {
                    if (ForkDirection == 2)//which way you carry the tote
                    {
                        Pic_Bin.Left = Pic_Sprite.Right;
                        Pic_Bin.Top = Pic_Sprite.Top;
                        Pic_Bin.Visible = true;
                    }
                    else if (ForkDirection == 1)
                    {
                        Pic_Bin.Left = Pic_Sprite.Left + 15;
                        Pic_Bin.Top = (Pic_Sprite.Top - Pic_Bin.Height);
                        Pic_Bin.Visible = true;
                    }
                    else if (ForkDirection == 4)
                    {
                        Pic_Bin.Left = Pic_Sprite.Left - 15;
                        Pic_Bin.Top = Pic_Sprite.Top;
                        Pic_Bin.Visible = true;
                    }
                    else if (ForkDirection == 3)
                    {
                        Pic_Bin.Left = Pic_Sprite.Left + 22;
                        Pic_Bin.Top = Pic_Sprite.Bottom;
                        Pic_Bin.Visible = true;
                    }
                }
                else if (carrying == 3) //noodles
                {
                    Pic_Litter.Top = Pic_Sprite.Top - Pic_Litter.Height;
                    Pic_Litter.Left = Pic_Sprite.Left - (Pic_Litter.Width / 2);
                    Pic_Litter.Visible = true;
                }
            }
            else if (Pic_Sprite.Right > Pic_Totes.Left && Pic_Sprite.Left < Pic_Totes.Right) //picking up randomly generated totes/bins
            {
                carrying = rndGen.Next(1, 3);
                if (carrying == 1)
                    Pic_Tote.Visible = false;
                if (carrying == 2)
                    Pic_Bin.Visible = false;
                lifting = true;
                Update_Image_Lift();
            }
            else if (Pic_Sprite.Right > Pic_Tote.Left && Pic_Sprite.Left < Pic_Tote.Right) //picking up a tote
            {
                carrying = 1;
                Pic_Tote.Visible = false;
                lifting = true;
                Update_Image_Lift();
            }
            else if (Pic_Sprite.Right > Pic_Bin.Left && Pic_Sprite.Left < Pic_Bin.Right) //picking up a bin
            {
                Pic_Bin.Visible = false;
                carrying = 2;
                lifting = true;
                Update_Image_Lift();
            }
            else if (Pic_Sprite.Right > Pic_Litter.Left && Pic_Sprite.Top < Pic_Litter.Top) //picking up litter (must be looking down at it)
            {
                if (ForkDirection == 1 || ForkDirection == 3)
                {
                    Pic_Litter.Visible = false;
                    carrying = 3;
                    lifting = true;
                    Update_Image_Lift();
                }
            }

        }
        private void Update_Image_Lift()
        {

            if (ForkDirection == 3)
            {
                if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingBackward;
                }
                else if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingBackward;
                }
            }
            else if (ForkDirection == 1)
            {
                if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingForward;
                }
                else if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingForward;
                }
            }
            else if (ForkDirection == 4)
            {
                if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingLeft;
                }
                else if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingLeft;
                }
            }
            else if (ForkDirection == 2)
            {
                if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingRight;
                }
                else if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingRight;
                }
            }
        }

        private void howDoIMoveToolStripMenuItem_Click(object sender, EventArgs e) //Help toolstrip
        {
            MessageBox.Show("Forklift Simulator 2015 uses standard WASD control", "Do You Even Game?");
        }

        private void howDoILiftToolStripMenuItem_Click(object sender, EventArgs e) // help
        {
            MessageBox.Show("To lift in Forklift Simulator 2015, use the space button", "Do You Even Lift?");
        }

        private void iWasExpectingHelpDocumentsToolStripMenuItem_Click(object sender, EventArgs e) //high expextations
        {
            MessageBox.Show("You Have High Expectations", "Do You Even Program?");
        }

        private void imReadyForFinalsToolStripMenuItem_Click(object sender, EventArgs e) //opens another Window!
        {
            using (Frm_Field f2 = new Frm_Field())
            {
                this.Hide();
                while (f2.ShowDialog() != DialogResult.OK)
                {
                    this.Enabled = false;
                }
                this.Enabled = true;
            }
        }

        public void UpdateTitle(string title) // an attampt to be able to update the title, never worked
        {
            using (Frm_Field f2 = new Frm_Field())
            {
                f2.Text = title;
            }
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e) // video
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/embed/hTyCIYZQ_1s");
        }
    }
}
