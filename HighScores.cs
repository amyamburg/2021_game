using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_game
{
    class HighScores
    {
        //we create a Constructor with 2 overloads, 1 for the player's name and one for their score
        public HighScores(string name, int score)
        {
            Name = name;
            Score = score;

        }
        //set properties so we can access the name and score
        public string Name { get; set; }

        public int Score { get; set; }

    }

}
