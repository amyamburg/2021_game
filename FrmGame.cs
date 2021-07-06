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

        public FrmGame()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 71);
                cupcake[i] = new Cupcake(x);
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
            }


        }

        private void TmrCupcake_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                cupcake[i].MoveCupcake();

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

    }
}
