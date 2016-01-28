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
    public partial class Frm_Field : Form
    {
        //You guessed it: Global variables
        const int speed = 2;
        bool[] player1 = new bool[2];
        bool[] player2 = new bool[2];
        bool lifting = false;
        int ForkDirection = 1;
        //1 = Forward
        //2 = Right
        //3 = Backward
        //4 = Left
        Frm_Practice_Arena Practice = new Frm_Practice_Arena(); // whats this? an initialized class?.....
        Random rndGen = new Random(); // not everything is as it seems
        int BlueScore = 0;
        int RedScore = 0;
        int carrying = 0;
        int time = 12000; //confusing timer, 1 tick != 1MS, 1 tick ~= 1 MS; 1000 ticks can be from 12-23 seconds
        int NoodlesThrown = 0; 

        public Frm_Field()
        {
            InitializeComponent(); //what were you looking for?
        }

        private void Frm_Field_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK; // allows the form to close
            Application.Exit(); // not necessarily required, but a formality
        }

        private void Frm_Field_KeyDown(object sender, KeyEventArgs e)
        {
            //Keydown controls
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.A) //left
                player1[0] = true;
            else if (keyCode == Keys.D) //right
                player1[1] = true;
            else if (keyCode == Keys.W) //up
                player2[0] = true;
            else if (keyCode == Keys.S) //down
                player2[1] = true;
            else if (keyCode == Keys.Space) //lift
            {
                Lift();
                Update_Image_Lift();
            }
        }

        private void Frm_Field_KeyUp(object sender, KeyEventArgs e)
        {
            //Keydown controls
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.A) //left
            {
                player1[0] = false;
                ForkDirection = 4;
            }
            else if (keyCode == Keys.D) //right
            {
                player1[1] = false;
                ForkDirection = 2;
            }
            else if (keyCode == Keys.W) //up
            {
                player2[0] = false;
                ForkDirection = 1;
            }
            else if (keyCode == Keys.S) //down
            {
                player2[1] = false;
                ForkDirection = 3;
            }
        }

        private void Tmr_Move_Tick(object sender, EventArgs e)
        {
            //Player Movement
            if (player1[0]) 
            {
                Pic_Sprite.Left -= speed;
                if (lifting == false) //checks for lifting to determine correct sprite
                {
                    Pic_Sprite.Image = Properties.Resources.GoingLeft;
                }
                else if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingLeft;
                }
            }
            if (player1[1])
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
            if (player2[0])
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
            if (player2[1])
            {
                Pic_Sprite.Top += speed;
                if (lifting == false)
                {
                    Pic_Sprite.Image = Properties.Resources.GoingBackward;
                }
                else if (lifting == true)
                {
                    Pic_Sprite.Image = Properties.Resources.LiftingBackward;
                }

            }
        }

        private void Tmr_Game_Tick(object sender, EventArgs e)
        {
            StayInField();
            CheckForScore();//like i said, more of a purpose <<<<
        }

        private void StayInField() //This (and a Few others) method is the same as the one in Frm_Practice_arena; a public method did not work (i believe it is my naming) fast/smooth enough to run a game
        {
            //Make sure there are no Escapees
            if (Pic_Sprite.Left < Pic_GameArea.Left)
            {
                Pic_Sprite.Left = Pic_GameArea.Left;
            }
            if (Pic_Sprite.Right > Pic_GameArea.Right)
            {
                Pic_Sprite.Left = Pic_GameArea.Right - 69;
            }
            if (Pic_Sprite.Top < Pic_GameArea.Top)
            {
                Pic_Sprite.Top = Pic_GameArea.Top;
            }
            if (Pic_Sprite.Bottom > Pic_GameArea.Bottom)
            {
                Pic_Sprite.Top = Pic_Sprite.Top  - 2;
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
                    else if (ForkDirection == 1) {
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
                    Pic_Litter.Left = Pic_Sprite.Left - (Pic_Litter.Width /2);
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
        private void Update_Image_Lift()//This is the code used to change betweeen lifting/not lifting , keeping the forklift direction
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
        private void UpdateScore() //used to update the labels
        {
            Lbl_BlueAlliance.Text = BlueScore.ToString();
            Lbl_RedAlliance.Text = RedScore.ToString();
            //if (RedScore > BlueScore) //code that never worked
            //{
            //    Practice.UpdateTitle(("The Red Alliance Is Winning By " + (RedScore - BlueScore).ToString()));
            //}
            //else if (BlueScore > RedScore)
            //{
            //    Practice.UpdateTitle(("The Blue Alliance Is Winning By " + (BlueScore - RedScore).ToString()));
            //}
            //else if (RedScore == BlueScore)
            //{
            //    Practice.UpdateTitle(("Both Alliances are Tied With a Score of " + RedScore.ToString()));
            //}
        }

        private void Pic_Sprite_Click(object sender, EventArgs e) //enables timers and begins the competition
        {
            Practice.UpdateTitle("Starting Match");
            Lbl_Game.Text = " ";
            Tmr_Game.Enabled = true;
            Tmr_Move.Enabled = true;
            Tmr_Time.Enabled = true;
            Tmr_BlueAlliance.Start();
        }

        private void CheckForScore() //its name is pretty self explanatory
        {
            //arrays added mainly for upgradeability
            PictureBox[] Goals = { 
                                          Pic_Scoring1,
                                          Pic_Scoring2
                                      };
            PictureBox[] Objs = {
                                    Pic_Tote,
                                    Pic_Bin
                                };
            int[] Scores = {
                               2,
                               4
                           };
            for (int i = 0; i < 2; i++) //check to see if someon scored a tote on either platform
            {
                if (Objs[0].Left >= Goals[i].Left && Objs[0].Right <= Goals[i].Right && Objs[0].Top >= Goals[i].Top && Objs[0].Bottom <= Goals[i].Bottom)
                {
                    Objs[0].Visible = false;
                    RedScore = RedScore + Scores[0];
                    UpdateScore();
                    Objs[0].Location = new Point(0, 0);
                    Lbl_Game.Text = "Red Alliance Scored " + Scores[0] + " Points ";
                }                
            }
            for (int i = 0; i < 2; i++) //check for a bin score
            {
                if (Objs[1].Left >= Goals[i].Left && Objs[1].Right <= Goals[i].Right && Objs[1].Top >= Goals[i].Top && Objs[1].Bottom <= Goals[i].Bottom)
                {
                    Objs[1].Visible = false;
                    RedScore = RedScore + Scores[1];
                    UpdateScore();
                    Objs[1].Location = new Point(0, 0);
                    Lbl_Game.Text = "Red Alliance Scored " + Scores[1] + " Points ";
                }
            }
            if (Pic_Litter.Left < Pic_Totes.Right && Pic_Litter.Location != new Point(0,0)) //check for noodle in litter
            {
                Pic_Litter.Visible = false;
                RedScore++;
                UpdateScore();
                Pic_Litter.Location = new Point(0, 0);
                Lbl_Game.Text = "Red Alliance Scored 1 Point";
            }

            
        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart(); //Restart FTW
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close(); //close .this
            Application.Exit(); //exit application
        }

        private void Tmr_Time_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time = time - 1;
                Lbl_Time.Text = Convert.ToInt64(time / 100).ToString(); //more of that confusing tick-timer system
            }
            else
            {
                EndGame();
            }
        }
        private void EndGame() //let them know who won
        {
            Tmr_Game.Stop();
            Tmr_Move.Stop();
            Tmr_Time.Stop();
            if (RedScore > BlueScore)
            {
                MessageBox.Show(("The Red Alliance Won By " + (RedScore - BlueScore).ToString()));
            }
            else if (BlueScore > RedScore)
            {
                MessageBox.Show(("The Blue Alliance Won By " + (BlueScore - RedScore).ToString()));
            }
            else if (RedScore == BlueScore)
            {
                MessageBox.Show(("Both Alliances Tied With a Score of " + RedScore.ToString()));
            }
            Btn_Quit.Visible = true;
            Btn_Restart.Visible = true;
        }

        private void Tmr_BlueAlliance_Tick(object sender, EventArgs e) //Blue team AI
        {
            if ((rndGen.Next(0, 10)) == 7) // 1/9 chance to run every interval
            {
                //Valid Pickup
                int ScoredObject = rndGen.Next(0, 100); 
                if (ScoredObject > 75) //bin (25% chance)
                {
                    //Bin Pickup/Stack
                    BlueScore = BlueScore + 4;
                    Lbl_Game.Text = "The Blue alliance Scored 4 Points";
                    UpdateScore();
                }
                else if (ScoredObject < 75) // tote (75% chance)
                {
                    //tote Pickup
                    BlueScore = BlueScore + 2;
                    Lbl_Game.Text = "The Blue alliance Scored 2 Points";
                    UpdateScore();
                }
                else if (ScoredObject == 75) //Robot breakdown (1% chance)
                {
                    //Easter egg
                    Lbl_Game.Text = "One of The Robots on the Blue Alliance Broke Down";
                    Tmr_BlueAlliance.Interval = 5000;
                }
            }
            else if ((rndGen.Next(0, 31)) == 30 && Pic_Litter.Left < Pic_GameArea.Left && NoodlesThrown < 10) //throw litter chance (1/30, if permitting)
            {
                //Noodle throwing
                Lbl_Game.Text = "The Blue Alliance Threw a pool Noddlea at your side";
                Pic_Litter.Left = rndGen.Next((Pic_GameArea.Left + 50), (Pic_GameArea.Right - 50));
                Pic_Litter.Top = rndGen.Next((Pic_GameArea.Top + 10), (Pic_GameArea.Bottom - 20));
            } 
            Tmr_BlueAlliance.Interval = rndGen.Next(320, 400); // randomly generate next interval
        }
    }
}

