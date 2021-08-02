using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _2021_game
{
    class Cat
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image cat;//variable for the cat's image

        public Rectangle catRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Cat()
        {
            //size of the cat
            x = 10;
            y = 415;
            width = 60;
            height = 60;
            cat = Properties.Resources.cat;
            catRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawCat(Graphics g)
        {
            //draw the cat
            g.DrawImage(cat, catRec);
        }
        public void moveCat(int mouseX) //move the cat to the x axis of the mouse
        {
            catRec.X = mouseX -(catRec.Width / 2);


        }


    }
}
