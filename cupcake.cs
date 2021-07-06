using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2021_game
{
    class Cupcake
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image cupcakeImage;//variable for the planet's image

        public Rectangle cupcakeRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Cupcake(int spacing)
        {
            x = spacing;
            y = 10;
            width = 35;
            height = 35;
            //planetImage contains the plane1.png image
            cupcakeImage = Properties.Resources.cupcake;
            cupcakeRec = new Rectangle(x, y, width, height);
        }


        // Methods for the Planet class
        public void DrawCupcake(Graphics g)
        {
            cupcakeRec = new Rectangle(x, y, width, height);

            g.DrawImage(cupcakeImage, cupcakeRec);
        }

        public void MoveCupcake()
        {
            

            cupcakeRec.Location = new Point(x, y);
        }

    }
}
