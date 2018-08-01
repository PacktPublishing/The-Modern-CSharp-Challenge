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

namespace BisectionRootFinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functionComboBox.Text = "x^2 - 4";
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            rootsListBox.Items.Clear();

            double xmin = double.Parse(xMinTextBox.Text);
            double xmax = double.Parse(xMaxTextBox.Text);
            int numTests = int.Parse(numTestsTextBox.Text);
            double maxError = double.Parse(maxErrorTextBox.Text);

            Func<double, double> F = null;
            if (functionComboBox.SelectedIndex == 0)
            {
                F = X2;
            }
            else if (functionComboBox.SelectedIndex == 1)
            {
                F = X3;
            }
            else if (functionComboBox.SelectedIndex == 2)
            {
                F = X4;
            }

            List<double> xmins;
            List<double> roots =
                FindRoots(F, xmin, xmax, numTests,
                    maxError, out xmins);

            foreach (double root in roots)
                rootsListBox.Items.Add(root);

            // Draw the curve.
            DrawCurve(F, xmin, xmax, roots, xmins);
        }

        // Find roots for the equation within the range xmin <= x <= xmax.
        private List<double> FindRoots(Func<double, double> F,
            double xmin, double xmax, int numTests,
            double maxError, out List<double> xmins)
        {
            xmins = new List<double>();
            List<double> roots = new List<double>();
            double dx = (xmax - xmin) / numTests;
            for (int i = 0; i < numTests; i++)
            {
                double x = xmin + dx * i;
                xmins.Add(x);
                double root = BinarySubdivision(F, x, x + dx, maxError);
                if (!double.IsNaN(root) &&
                    !roots.Contains(root, maxError)) roots.Add(root);
            }
            return roots;
        }

        // Search this interval for a root.
        private double BinarySubdivision(Func<double, double> F,
            double xmin, double xmax, double maxError)
        {
            // Make sure that F(xmin) and F(xmax) have different signs.
            if (Math.Sign(F(xmin)) == Math.Sign(F(xmax)))
                return double.NaN;

            for (;;)
            {
                double x = (xmin + xmax) / 2.0;
                double y = F(x);
                double error = Math.Abs(y);
                if (error < maxError) return x;

                if (Math.Sign(y) == Math.Sign(F(xmin)))
                    xmin = x;
                else
                    xmax = x;
            }
        }

        private double X2(double x)
        {
            return x * x - 4;
        }

        private double X3(double x)
        {
            return x * x * x - 3 * x * x + 3;
        }

        private double X4(double x)
        {
            return (x * x * x * x + 2 * x * x * x - 12 * x * x - 2 * x + 6) / 10;
        }

        private void DrawCurve(Func<double, double> F,
            double xmin, double xmax, List<double> roots, List<double> xmins)
        {
            int wid = graphPictureBox.ClientSize.Width;
            int hgt = graphPictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(Color.White);
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                float scale = (float)(wid / (xmax - xmin));
                gr.ScaleTransform(scale, -scale);
                gr.TranslateTransform(wid / 2, hgt / 2, MatrixOrder.Append);

                using (Pen pen = new Pen(Color.Black, 0))
                {
                    // Draw the axes.
                    gr.DrawLine(pen, -10000, 0, 10000, 0);
                    gr.DrawLine(pen, 0, -10000, 0, 10000);

                    // Draw the xmins.
                    pen.Color = Color.Red;
                    foreach (double x in xmins)
                    {
                        gr.DrawLine(pen, (float)x, -1, (float)x, 1);
                    }

                    // Draw the curve.
                    pen.Color = Color.Blue;

                    // Make a point list.
                    List<PointF> points = new List<PointF>();
                    float dx = (float)((xmax - xmin) / wid);
                    for (float x = (float)xmin; x <= xmax; x += dx)
                    {
                        points.Add(new PointF(x, (float)F(x)));
                    }

                    gr.DrawLines(pen, points.ToArray());

                    // Draw the roots.
                    pen.Color = Color.Red;
                    float gap = 3 * dx;
                    foreach (double root in roots)
                    {
                        float x = (float)root;
                        float y = (float)F(root);
                        RectangleF rect = new RectangleF(
                            x - gap, y - gap, 2 * gap, 2 * gap);
                        gr.DrawEllipse(pen, rect);
                    }
                }
            }
            graphPictureBox.Image = bm;
        }
    }
}
