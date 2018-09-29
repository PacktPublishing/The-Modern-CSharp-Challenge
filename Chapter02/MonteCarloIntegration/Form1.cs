using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace MonteCarloIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functionComboBox.Text = "x^2 + 1";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            estimatedLabel.Text = "";
            calculatedLabel.Text = "";
            errorLabel.Text = "";

            double xmin = double.Parse(xMinTextBox.Text);
            double xmax = double.Parse(xMaxTextBox.Text);
            double ymin = double.Parse(yMinTextBox.Text);
            double ymax = double.Parse(yMaxTextBox.Text);
            int numPoints = int.Parse(numPointsTextBox.Text);

            Func<double, double> F = null;
            Func<double, double> AntiF = null;
            if (functionComboBox.SelectedIndex == 0)
            {
                F = X2;
                AntiF = AntiX2;
            }
            else if (functionComboBox.SelectedIndex == 1)
            {
                F = X3;
                AntiF = AntiX3;
            }
            else if (functionComboBox.SelectedIndex == 2)
            {
                F = X4;
                AntiF = AntiX4;
            }

            // Perform the integration.
            double estimated = MonteCarloIntegrate(F, xmin, xmax, ymin, ymax, numPoints);
            estimatedLabel.Text = estimated.ToString("0.0000");

            // Check.
            double calculated = AntiF(xmax) - AntiF(xmin);
            calculatedLabel.Text = calculated.ToString("0.0000");

            double error = estimated - calculated;
            errorLabel.Text = error.ToString("0.0000");

            // Draw points for a Monte Carlo integration.
            DrawMonteCarloIntegration(F, xmin, xmax, ymin, ymax, numPoints);
        }

        // Use Monte Carlo integration to find the area under the curve.
        private double MonteCarloIntegrate(Func<double, double> F,
            double xmin, double xmax, double ymin, double ymax, int numPoints)
        {
            Random rand = new Random();
            int numHits = 0;

            // Make the random points.
            for (int i = 0; i < numPoints; i++)
            {
                // Make a random point xmin <= x <= xmax, ymin <= y <= ymax.
                double x = rand.NextDouble(xmin, xmax);
                double y = rand.NextDouble(ymin, ymax);

                // See if the point is below the function.
                if ((y >= 0) && (y <= F(x))) numHits++;
            }

            // Get the hit fraction.
            double fraction = numHits / (double)numPoints;

            // Estimate the area.
            return fraction * (xmax - xmin) * (ymax - ymin);
        }

        // Draw points for a Monte Carlo integration.
        private void DrawMonteCarloIntegration(Func<double, double> F,
            double xmin, double xmax, double ymin, double ymax, int numPoints)
        {
            // Draw the area -5 <= x <= 5, -5 <= y <= 5.
            const float wxmin = -5;
            const float wxmax = 5;
            const float wymin = -5;
            const float wymax = 5;

            Random rand = new Random();

            // Make a bitmap to show points.
            int wid = graphPictureBox.ClientSize.Width;
            int hgt = graphPictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // Fit the desired area to the bitmap.
                float scale = (float)(wid / (wxmax - wxmin));
                gr.ScaleTransform(scale, -scale);
                gr.TranslateTransform(wid / 2, hgt / 2, MatrixOrder.Append);

                // Get the size of a pixel in world coordinates.
                float dx = (float)((wxmax - wxmin) / wid);

                using (Pen pen = new Pen(Color.Black, 0))
                {
                    // Draw axes.
                    gr.DrawLine(pen, wxmin, 0, wxmax, 0);
                    gr.DrawLine(pen, 0, wymin, 0, wymax);
                    const float tic = 0.25f;
                    for (int i = (int)wxmin - 1; i <= wxmax + 1; i++)
                        gr.DrawLine(pen, i, -tic, i, tic);
                    for (int i = (int)wymin - 1; i <= wymax + 1; i++)
                        gr.DrawLine(pen, -tic, i, tic, i);
                    gr.DrawRectangle(pen, (float)xmin, (float)ymin,
                        (float)(xmax - xmin), (float)(ymax - ymin));

                    // Draw no more than 10,000 points.
                    if (numPoints > 10000) numPoints = 10000;

                    // Make the random points.
                    for (int i = 0; i < numPoints; i++)
                    {
                        // Make a random point xmin <= x <= xmax, ymin <= y <= ymax.
                        double x = rand.NextDouble(xmin, xmax);
                        double y = rand.NextDouble(ymin, ymax);

                        // Plot the point.
                        float fx = (float)x - dx;
                        float fy = (float)y - dx;
                        if ((y >= 0) && (y <= F(x)))
                            gr.FillRectangle(Brushes.Gray, fx, fy, 2 * dx, 2 * dx);
                        else
                            gr.FillRectangle(Brushes.Black, fx, fy, 2 * dx, 2 * dx);
                    }

                    // Draw the curve.
                    pen.Width = 2 * dx;
                    List<PointF> points = new List<PointF>();
                    for (float x = (float)wxmin; x <= wxmax; x += dx)
                        points.Add(new PointF(x, (float)F(x)));
                    gr.DrawLines(pen, points.ToArray());
                    pen.Width = 0;
                }
            }

            // Display the plotted points.
            graphPictureBox.Image = bm;
        }

        private double X2(double x)
        {
            return x * x + 1;
        }
        private double AntiX2(double x)
        {
            return x * x * x / 3 + x;
        }

        private double X3(double x)
        {
            return x * x * x - 2 * x * x + 3;
        }
        private double AntiX3(double x)
        {
            return x * x * x * x / 4 - 2 * x * x * x / 3 + 3 * x;
        }

        private double X4(double x)
        {
            return Math.Sin(x) + Math.Cos(2 * x) + 2.5;
        }
        private double AntiX4(double x)
        {
            return -Math.Cos(x) + Math.Sin(2 * x) / 2 + 2.5 * x;
        }

        // Enter reasonable bounds for this function.
        private void functionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (functionComboBox.SelectedIndex == 0)
            {
                xMinTextBox.Text = "-1.5";
                xMaxTextBox.Text = "1.5";
                yMinTextBox.Text = "-2";
                yMaxTextBox.Text = "4";
            }
            else if (functionComboBox.SelectedIndex == 1)
            {
                xMinTextBox.Text = "-1";
                xMaxTextBox.Text = "2";
                yMinTextBox.Text = "-1";
                yMaxTextBox.Text = "4";
            }
            else if (functionComboBox.SelectedIndex == 2)
            {
                xMinTextBox.Text = "-3";
                xMaxTextBox.Text = "3";
                yMinTextBox.Text = "-1";
                yMaxTextBox.Text = "4";
            }
        }
    }
}
