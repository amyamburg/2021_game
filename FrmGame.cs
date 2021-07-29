using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_game
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g
        Cupcake[] cupcake = new Cupcake[7]; //create the object, planet1
        Random yspeed = new Random();
        Random speed = new Random();
        Cat cat = new Cat();
        Lettuce[] lettuce = new Lettuce[7];
        int score, lives;
        string username = "";
        bool paused = false;
        public FrmGame()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 71);
       
                cupcake[i] = new Cupcake(x);
                lettuce[i] = new Lettuce(x);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                cupcake[i].DrawCupcake(g);
                lettuce[i].DrawLettuce(g);
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(0, 31);
                cupcake[i].y += rndmspeed;
                int rndmspeed1 = speed.Next(0, 16);
                lettuce[i].y += rndmspeed1;
            }
            cat.DrawCat(g);

        }

        private void TmrCupcake_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                cupcake[i].MoveCupcake();
                if (cat.catRec.IntersectsWith(cupcake[i].cupcakeRec))
                {
                    //reset planet[i] back to top of panel
                    cupcake[i].y = 30; // set  y value of planetRec
                    score += 1;// lose a life
                    LblScore.Text = score.ToString();// display number of lives
                    
                }

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (cupcake[i].y >= PnlGame.Height)
                {
                    cupcake[i].y = 10;
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void PnlGame_MouseMove(object sender, MouseEventArgs e)
        {
            cat.moveCat(e.X);
            

        }

        private void TmrLettuce_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                lettuce[i].MoveLettuce();
                if (cat.catRec.IntersectsWith(lettuce[i].lettuceRec))
                {
                    //reset planet[i] back to top of panel
                    lettuce[i].y = 10; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                //if a planet reaches the bottom of the Game Area reposition it at the top

                Random rand = new Random();
                int randomPos = rand.Next(-70, 10);
                if (lettuce[i].y >= PnlGame.Height)
                {
                    lettuce[i].y = randomPos;
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel


        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);


        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string text = TxtName.Text;

            if (text.Trim() == "") return;
            for(int i = 0; i < text.Length; i++)
            {
                if(!char.IsLetter(text[i]))
                {
                    MessageBox.Show("use letters");
                    TxtName.Text = "";
                    return;
                }
            }

            username = TxtName.Text;
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();



            easyToolStripMenuItem.Enabled = false;
            mediumToolStripMenuItem.Enabled = false;
            hardToolStripMenuItem.Enabled = false;
            TmrCupcake.Enabled = true;
            TmrLettuce.Enabled = true;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 9;
            LblLives.Text = lives.ToString();
            MessageBox.Show("Difficulty set to Easy");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 6;
            LblLives.Text = lives.ToString();
            MessageBox.Show("Difficulty set to Medium");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 3;
            LblLives.Text = lives.ToString();
            MessageBox.Show("Difficulty set to Hard");
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TmrCupcake.Enabled = false;
            TmrLettuce.Enabled = false;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string title = "Paused";
            DialogResult result  =  MessageBox.Show("Paused, click OK to unpause", title, buttons);

           if(result == DialogResult.OK)
            {
                TmrCupcake.Enabled = true;
                TmrLettuce.Enabled = true;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string title = "Quit?";
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrLettuce.Enabled = false;
                TmrCupcake.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }
}
