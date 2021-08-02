using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2021_game
{
    class Lettuce
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image lettuceImage;//variable for the lettuce's image

        public Rectangle lettuceRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Lettuce(int spacing)
        {

             x = spacing;
             y = -700;
             width = 35;
             height = 35;

            //lettuceImage contains the lettuce.png image
            lettuceImage = Properties.Resources.lettuce;
            lettuceRec = new Rectangle(x, y, width, height);
        }


        // Methods for the Planet class
        public void DrawLettuce(Graphics g)
        {
            //draw lettuces
            lettuceRec = new Rectangle(x, y, width, height);
            g.DrawImage(lettuceImage, lettuceRec);
        }

        public void MoveLettuce()
        {
           
            //move lettuces

            lettuceRec.Location = new Point(x, y);
        }
    }
}
