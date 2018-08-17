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
using System.Threading;     // Used by Interlocked.

namespace ParallelMonteCarloPi
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

        // Random doesn't like working on multiple threads so each method uses its own.
        // private Random Rand = new Random();
        private int NumHits = 0;
        private object LockObject = new object();
        private int MonteCarloWidth = 0, MonteCarloHeight = 0;
        private Bitmap MonteCarloBitmap = null;
        private const int PointsPerCall = 10000;

        // Use Monte Carlo simulation to estimate pi.
        private double MonteCarloPi(int numPoints)
        {
            // Make a bitmap to show points.
            MonteCarloWidth = pointsPictureBox.ClientSize.Width;
            MonteCarloHeight = pointsPictureBox.ClientSize.Height;
            MonteCarloBitmap = new Bitmap(MonteCarloWidth, MonteCarloWidth);
            using (Graphics gr = Graphics.FromImage(MonteCarloBitmap))
            {
                gr.Clear(Color.White);
                gr.DrawEllipse(Pens.Black, 0, 0, MonteCarloWidth - 1, MonteCarloWidth - 1);
            }

            // Make the random points.
            NumHits = 0;
            int numMethods = numPoints / PointsPerCall;
            Parallel.For(0, numMethods, TestPoint);

            // Display the plotted points.
            pointsPictureBox.Image = MonteCarloBitmap;

            // Get the hit fraction.
            double fraction = NumHits / (double)(numMethods * PointsPerCall);

            // Estimate pi.
            return 4.0 * fraction;
        }

        private void TestPoint(int i)
        {
            Random rand = new Random(i * DateTime.Now.Millisecond);
            int myHits = 0;
            for (int pointNum = 0; pointNum < PointsPerCall; pointNum++)
            {
                // Make a random point 0 <= x < 1.
                double x = rand.NextDouble();
                double y = rand.NextDouble();

                // See how far the point is from (0.5, 0.5).
                double dx = x - 0.5;
                double dy = y - 0.5;
                if (dx * dx + dy * dy < 0.25) myHits++;

                if (i == 0)
                {
                    int ix = (int)(MonteCarloWidth * x);
                    int iy = (int)(MonteCarloHeight * y);
                    if (dx * dx + dy * dy < 0.25)
                        MonteCarloBitmap.SetPixel(ix, iy, Color.Gray);
                    else
                        MonteCarloBitmap.SetPixel(ix, iy, Color.Black);
                }
            }

            // Slightly slower.
            //Interlocked.Add(ref NumHits, myHits);

            // Slightly faster.
            lock (LockObject)
            {
                NumHits += myHits;
            }
        }
    }
}
