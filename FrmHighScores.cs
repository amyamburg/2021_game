using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _2021_game
{
    public partial class FrmHighScores : Form
    {
        string Path = Application.StartupPath + @"\HighScores.txt";
        List<HighScores> highScores = new List<HighScores>();

        public FrmHighScores(string playerName, string playerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            LblPlayerName.Text = playerName;
            LblPlayerScore.Text = playerScore;

            var reader = new StreamReader(Path);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));


            }
            reader.Close();

        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                //list 10 high score names and scores in their boxes
                lstBoxName.Items.Add(s.Name);
                lstBoxScore.Items.Add(s.Score);

            }
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(LblPlayerScore.Text) > lowest_score)
            { //if the user gets a score that is higher than the lowest score, tell them they made it to the top 10.
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                //add their name and score as a high score
                highScores.Add(new HighScores(LblPlayerName.Text, int.Parse(LblPlayerScore.Text)));

            }
            else
            {
                //tell the user that they did not get enough points to get on the scoreboard
                lblMessage.Text = "Keep trying to make the top ten!";
            }
            
            SortHighScores();

            DisplayHighScores();

        }
        public void SortHighScores()
        {  //put the high scores in order of highest to lowest, and only use the top 10
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }

        public void SaveHighScores() //add users' high score to highscores so it will show next time
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(Path, builder.ToString());
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            //start the game form up and hide the high scores form
            FrmGame FrmGame2 = new FrmGame();
            Hide();
            FrmGame2.ShowDialog();

        }
    }
}
