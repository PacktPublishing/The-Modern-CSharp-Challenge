using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace MonteCarloPi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            errorTextBox.Clear();
            timeTextBox.Clear();
            Refresh();

            int numPoints = int.Parse(numPointsTextBox.Text);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            double pi = MonteCarloPi(numPoints);
            watch.Stop();

            resultTextBox.Text = pi.ToString("0.000000");
            double error = pi - Math.PI;
            errorTextBox.Text = error.ToString("0.000000");
            timeTextBox.Text = watch.Elapsed.TotalSeconds.ToString("0.0000");
        }

        // Use Monte Carlo simulation to estimate pi.
        private double MonteCarloPi(long numPoints)
        {
            Random rand = new Random();

            // Make a bitmap to show points.
            int wid = pointsPictureBox.ClientSize.Width;
            int hgt = pointsPictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.DrawEllipse(Pens.Black, 0, 0, wid - 1, hgt - 1);
            }

            // Make the random points.
            int numHits = 0;
            for (int i = 0; i < numPoints; i++)
            {
                // Make a random point 0 <= x < 1.
                double x = rand.NextDouble();
                double y = rand.NextDouble();

                // See how far the point is from (0.5, 0.5).
                double dx = x - 0.5;
                double dy = y - 0.5;
                if (dx * dx + dy * dy < 0.25) numHits++;

                // Plot up to 10,000 points.
                if (i < 10000)
                {
                    int ix = (int)(wid * x);
                    int iy = (int)(hgt * y);
                    if (dx * dx + dy * dy < 0.25)
                        bm.SetPixel(ix, iy, Color.Gray);
                    else
                        bm.SetPixel(ix, iy, Color.Black);
                }
            }

            // Display the plotted points.
            pointsPictureBox.Image = bm;

            // Get the hit fraction.
            double fraction = numHits / (double)numPoints;

            // Estimate pi.
            return 4.0 * fraction;
        }
    }
}
