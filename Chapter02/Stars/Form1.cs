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

namespace Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The number of sides and the skip factor.
        private int NumSides, Skip;

        // Draw a new star.
        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareStar();

        }
        private void goButton_Click(object sender, EventArgs e)
        {
            PrepareStar();
        }

        // Get the parameter to draw a new start and refresh.
        private void PrepareStar()
        {
            NumSides = int.Parse(numSidesTextBox.Text);
            Skip = int.Parse(skipTextBox.Text);
            starPictureBox.Refresh();
        }

        // Draw the star.
        private void starPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Get positioning values.
            PointF center = new PointF(
                starPictureBox.ClientSize.Width / 2f,
                starPictureBox.ClientSize.Height / 2f);
            const float margin = 5;
            float radius = Math.Min(
                starPictureBox.ClientSize.Width / 2f,
                starPictureBox.ClientSize.Height / 2f) - margin;

            // Draw the poylgon.
            double theta = -Math.PI / 2.0;
            double dtheta = 2 * Math.PI / NumSides;
            PointF[] points = new PointF[NumSides];
            for (int i = 0; i < NumSides; i++)
            {
                points[i] = new PointF(
                    (float)(center.X + radius * Math.Cos(theta)),
                    (float)(center.Y + radius * Math.Sin(theta)));
                theta += dtheta;
            }
            e.Graphics.DrawPolygon(Pens.Red, points);

            // Draw the star.
            for (int i = 0; i < NumSides; i++)
                e.Graphics.DrawLine(Pens.Blue,
                    points[i], points[(i + Skip) % NumSides]);
        }
    }
}
