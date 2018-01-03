using Nakov.TurtleGraphics;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Green;

            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.DarkGreen;

            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(60);
            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            Turtle.PenColor = Color.Yellow;

            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(170);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Red;

            for (int i = 0; i < 3; i++)
            {
                for (int index = 0; index < 22; index++)
                {
                    Turtle.Forward(index * 10);
                    Turtle.Rotate(120);
                }
            }
        }
    }
}
