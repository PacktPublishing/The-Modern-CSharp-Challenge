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

namespace CircleSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The points.
        private List<Point> Points = new List<Point>();
        private RectangleF Circle = new RectangleF(-1, -1, 1, 1);

        // Save a new point.
        private void circlePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Points.Count == 3) Points = new List<Point>();
            Points.Add(e.Location);

            // See if we have all three points.
            if (Points.Count == 3)
                Circle = FindCircle(Points[0], Points[1], Points[2]);

            // Redraw.
            circlePictureBox.Refresh();
        }

        // Draw whatever information we have.
        private void circlePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the points.
            const int r = 3;
            foreach (Point point in Points)
                e.Graphics.DrawEllipse(Pens.Red,
                    point.X - r, point.Y - r, 2 * r, 2 * r);

            // Draw the circle.
            if (Points.Count == 3)
                e.Graphics.DrawEllipse(Pens.Blue, Circle);
        }

        // Return a RectangleF that defines a circle passing through the three points.
        private RectangleF FindCircle(PointF p0, PointF p1, PointF p2)
        {
            // Find a bisector for p0-p1.
            PointF b00, b01;
            FindBisector(p0, p1, out b00, out b01);

            // Find a bisector for p1-p2.
            PointF b10, b11;
            FindBisector(p1, p2, out b10, out b11);

            // Find the bisectors' point of intersection.
            bool linesAreParallel;
            PointF center = IntersectLines(b00, b01, b10, b11, out linesAreParallel);
            if (linesAreParallel)
            {
                MessageBox.Show("The circle's points are colinear");
                return new RectangleF(-1, -1, -1, -1);
            }

            // Return the circle.
            float radius = Distance(center, p0);
            return new RectangleF(
                center.X - radius, center.Y - radius,
                2 * radius, 2 * radius);
        }

        // Find a bisector for the segment connecting the two points.
        private void FindBisector(PointF p0, PointF p1, out PointF b0, out PointF b1)
        {
            // Find the midpoint.
            b0 = new PointF(
                (p0.X + p1.X) / 2,
                (p0.Y + p1.Y) / 2);

            // Find the p0-p1 direction vector.
            float dx = p1.X - p0.X;
            float dy = p1.Y - p0.Y;

            // Add <dy, -dx> to b0 to get b1.
            b1 = new PointF(
                b0.X + dy,
                b0.Y - dx);
        }

        // Find the point of intersection between the lines p00-p01 and p10-p11.
        private PointF IntersectLines(PointF p00, PointF p01, PointF p10, PointF p11,
            out bool linesAreParallel)
        {
            // Get the segments' parameters.
            float v0x = p01.X - p00.X;
            float v0y = p01.Y - p00.Y;
            float v1x = p11.X - p10.X;
            float v1y = p11.Y - p10.Y;

            // Solve for t0 and t1.
            float denominator = v0y * v1x - v0x * v1y;

            float t0 = (v1y * (p00.X - p10.X) - v1x * (p00.Y - p10.Y)) / denominator;
            if (float.IsInfinity(t0))
            {
                linesAreParallel = true;
                return new PointF(-1, -1);
            }

            linesAreParallel = false;
            PointF p0 = new PointF(
                p00.X + t0 * v0x,
                p00.Y + t0 * v0y);
            return p0;
        }

        // Return the distance between two points.
        private float Distance(PointF p0, PointF p1)
        {
            float dx = p0.X - p1.X;
            float dy = p0.Y - p1.Y;
            float distanceSquared = dx * dx + dy * dy;
            return (float)Math.Sqrt(distanceSquared);
        }
    }
}
