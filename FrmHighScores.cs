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
        string binPath = Application.StartupPath + @"\HighScores.txt";
        public FrmHighScores(string playerName, string playerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            LblPlayerName.Text = playerName;
            LblPlayerScore.Text = playerScore;

            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');

            }


        }
    }
}
