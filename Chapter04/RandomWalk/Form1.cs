using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Rand = new Random();
        Point[] Points = null;

        // Generate a random walk.
        private void walkButton_Click(object sender, EventArgs e)
        {
            // Get parameters.
            int numSteps = int.Parse(numStepsTextBox.Text);
            int stepSize = int.Parse(stepSizeTextBox.Text);

            // Start in the center of the PictureBox.
            int x = walkPictureBox.ClientSize.Width / 2;
            int y = walkPictureBox.ClientSize.Height / 2;

            // Build the points.
            Points = new Point[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Points[i] = new Point(x, y);
                switch (Rand.Next(0, 4))
                {
                    case 0:             // Up.
                        y -= stepSize;
                        break;
                    case 1:             // Right.
                        x += stepSize;
                        break;
                    case 2:             // Down.
                        y += stepSize;
                        break;
                    case 3:             // Left.
                        x -= stepSize;
                        break;
                }
            }

            // Redraw.
            walkPictureBox.Refresh();
        }

        // Draw the walk.
        private void walkPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (Points == null) return;

            e.Graphics.Clear(walkPictureBox.BackColor);
            e.Graphics.DrawLines(Pens.Blue, Points);
        }
    }
}
