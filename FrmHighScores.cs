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
                lstBoxName.Items.Add(s.Name);
                lstBoxScore.Items.Add(s.Score);

            }
        }

        private void FrmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(LblPlayerScore.Text) > lowest_score)
            {
                lblMessage.Text = "You have made the Top Ten! Well Done!";
                highScores.Add(new HighScores(LblPlayerName.Text, int.Parse(LblPlayerScore.Text)));

            }
            else
            {
                lblMessage.Text = "Keep trying to make the top ten!";
            }

            SortHighScores();

            DisplayHighScores();

        }
        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }

        public void SaveHighScores()
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

            FrmGame FrmGame2 = new FrmGame();
            Hide();
            FrmGame2.ShowDialog();

        }
    }
}
