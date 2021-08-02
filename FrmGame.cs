using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace _2021_game
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g
        Cupcake[] cupcake = new Cupcake[7]; //create the object, cupcake. 7 of them.
        Random yspeed = new Random(); //random speed for the cupcakes
        Random speed = new Random(); //random speed for the lettuce
        Cat cat = new Cat(); //create the object, cat
        Lettuce[] lettuce = new Lettuce[7]; //create the object, lettuce. 7 of them.
        int score, lives;
        string username = "";
        bool paused = false;
        public FrmGame()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 71);
       
                cupcake[i] = new Cupcake(x); //draw the cupcakes
                lettuce[i] = new Lettuce(x); //draw the lettuces
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            
             
            for (int i = 0; i < 7; i++)
            {
                //call the cupcake's class's DrawCupcake method to draw the images
                cupcake[i].DrawCupcake(g);
                //call the lettuce's class's DrawLettuce method to draw the images
                lettuce[i].DrawLettuce(g);
                // generate a random number from 0 to 31 and put it in rndmspeed, used for cupcake's speed
                int rndmspeed = yspeed.Next(0, 31);
                cupcake[i].y += rndmspeed;
                // generate a random number from 0 to 16 and put it in rndmspeed1, used for lettuce's speed
                int rndmspeed1 = speed.Next(0, 16);
                lettuce[i].y += rndmspeed1;
            }
            //draw the cat
            cat.DrawCat(g);

        }

        private void TmrCupcake_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                cupcake[i].MoveCupcake();
                if (cat.catRec.IntersectsWith(cupcake[i].cupcakeRec)) //add points when cupcakes touches the cat
                {
                    //reset cupcake[i] back to top of panel
                    cupcake[i].y = 30; // set  y value of cupcakeRec
                    score += 1;// gain a point
                    LblScore.Text = score.ToString();// display score
                    
                }

                //if a cupcake reaches the bottom of the Game Area reposition it at the top
                if (cupcake[i].y >= PnlGame.Height)
                {
                    cupcake[i].y = 10;
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void PnlGame_MouseMove(object sender, MouseEventArgs e)
        {
            //move the cat where the mouse moves on the x axis
            cat.moveCat(e.X);
            

        }

        private void TmrLettuce_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                lettuce[i].MoveLettuce(); // move lettuce
                if (cat.catRec.IntersectsWith(lettuce[i].lettuceRec)) //take lives off if the lettuce touches the cat
                {
                    //reset lettuce[i] back to top of panel
                    lettuce[i].y = 10; // set  y value of lettuceRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }

                //if a lettuce reaches the bottom of the Game Area reposition it at the top

                Random rand = new Random(); //make a random number to use for the y position
                int randomPos = rand.Next(-70, 10);
                if (lettuce[i].y >= PnlGame.Height)
                {
                    lettuce[i].y = randomPos; //lettuce is at a random position between y= -70 and 10
                }


            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel


        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
            //display instructions
            MessageBox.Show("move your mouse left and right to move the cat left and right. \n Don't get hit by the cabbage! \n Every cupcake that the cat eats by touching scores a point. \n If a cabbage hits your cat, a life is lost! \n \n please select a difficulty before you press start, you can not change it after pressing start. \n Click Start to begin", "Cabbages, Cats and Cupcakes game Instructions");
            TxtName.Focus();


        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string text = TxtName.Text;

            if (text.Trim() == "") return;
            for(int i = 0; i < text.Length; i++)
            {
                if(!char.IsLetter(text[i]))
                { //if a character that is not a letter is written into the name textbox
                    MessageBox.Show("use letters"); //tell the user to use only letters
                    TxtName.Text = ""; //clear the name text box
                    return;
                }
            }

            username = TxtName.Text;
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0; //clear score to 0 when game starts
            LblScore.Text = score.ToString();


            //prevent users from changing difficulty after they start the game
            easyToolStripMenuItem.Enabled = false; 
            mediumToolStripMenuItem.Enabled = false;
            hardToolStripMenuItem.Enabled = false;
            //allow the cupcakes and lettuces to start moving
            TmrCupcake.Enabled = true;
            TmrLettuce.Enabled = true;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 9; //9 lives for easy level
            LblLives.Text = lives.ToString();
            //tell the user the difficulty is set
            MessageBox.Show("Difficulty set to Easy");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 6; //6 lives for medium level
            LblLives.Text = lives.ToString();
            //tell the user the difficulty is set
            MessageBox.Show("Difficulty set to Medium");
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lives = 3; //3 lives for hard level
            LblLives.Text = lives.ToString();
            //tell the user the difficulty is set
            MessageBox.Show("Difficulty set to Hard");
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stop the cupcakes and lettuces from moving
            TmrCupcake.Enabled = false;
            TmrLettuce.Enabled = false;
            //button to press to unpause
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            //tell the user that the game is paused
            string title = "Paused";
            //tell the user how to unpause
            DialogResult result  =  MessageBox.Show("Paused, click OK to unpause", title, buttons);

           if(result == DialogResult.OK)
            {
                //let the cupcakes and lettuces continue moving when ok is pressed
                TmrCupcake.Enabled = true;
                TmrLettuce.Enabled = true;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //give the user options to quit or not
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //ask the user if they want to quit
            string title = "Quit?";
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", title, buttons);
            if (result == DialogResult.Yes)
            {
                //exit the game
                Application.Exit();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //show the high scores form and hide the game form
            FrmHighScores FrmHighScore2 = new FrmHighScores(TxtName.Text, LblScore.Text);
            Hide();
            FrmHighScore2.ShowDialog();


        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                //when the user runs out of lives; stop the cupcakes, lettuce, and tell the user that they have lost.
                TmrLettuce.Enabled = false;
                TmrCupcake.Enabled = false;
                MessageBox.Show("Game Over");
                //reset lives to default easy mode for if they decide to play again
                lives = 9;
                //allow the user to change difficulty
                easyToolStripMenuItem.Enabled = true;
                mediumToolStripMenuItem.Enabled = true;
                hardToolStripMenuItem.Enabled = true;

            }
        }

    }
}
