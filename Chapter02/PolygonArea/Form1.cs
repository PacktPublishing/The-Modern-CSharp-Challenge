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

namespace PolygonArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The polygon's points.
        private List<Point> PolygonPoints = new List<Point>();

        // True when we are done drawing the polygon.
        private bool PolygonIsReady = false;

        // Add a point to the polygon.
        private void polygonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Close the polygon.
                PolygonIsReady = true;

                // Calculate the area.
                areaLabel.Text = PolygonArea(PolygonPoints).ToString("0.00");
            }
            else
            {
                if (PolygonIsReady)
                {
                    // Start a new polygon.
                    PolygonIsReady = false;
                    PolygonPoints = new List<Point>();
                    areaLabel.Text = "";
                }

                // Add the point to the polygon.
                PolygonPoints.Add(e.Location);
            }

            polygonPictureBox.Refresh();
        }

        // Draw the polygon so far.
        private void polygonPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (PolygonIsReady)
            {
                if (PolygonPoints.Count > 2)
                    e.Graphics.DrawPolygon(Pens.Red, PolygonPoints.ToArray());
            }
            else
            {
                if (PolygonPoints.Count > 1)
                    e.Graphics.DrawLines(Pens.Red, PolygonPoints.ToArray());

                const int gap = 3;
                foreach (Point point in PolygonPoints)
                    e.Graphics.DrawEllipse(Pens.Red,
                        point.X - gap, point.Y - gap,
                        2 * gap, 2 * gap);
            }
        }

        // Calculate the polygon's area.
        private float PolygonArea(List<Point> points)
        {
            int numPoints = points.Count;
            if (numPoints < 3)
                throw new Exception("The polygon must have at least three vertices");

            // Repeat the first point at the end for convenience.
            points.Add(points[0]);

            // Loop over the polygon's segments.
            float area = 0;
            for (int i = 0; i < numPoints; i++)
            {
                float width = points[i + 1].X - points[i].X;
                area += width * (points[i + 1].Y + points[i].Y) / 2f;
            }

            // Remove the repeated first point.
            points.RemoveAt(numPoints);

            return Math.Abs(area);
        }
    }
}
