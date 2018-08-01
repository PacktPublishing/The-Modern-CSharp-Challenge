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

namespace LineCircleIntersection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The points.
        private List<Point> CirclePoints = new List<Point>();
        private RectangleF Circle = new RectangleF(-1, -1, 1, 1);
        private List<Point> LinePoints = new List<Point>();
        private List<PointF> Intersections = new List<PointF>();

        // Save a new point.
        private void circlePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CirclePoints.Count == 3) CirclePoints = new List<Point>();
                CirclePoints.Add(e.Location);
            }
            else
            {
                if (LinePoints.Count == 2) LinePoints = new List<Point>();
                LinePoints.Add(e.Location);
            }

            // See if we have three circle points.
            Intersections = new List<PointF>();
            if (CirclePoints.Count == 3)
            {
                Circle = FindCircle(CirclePoints[0], CirclePoints[1], CirclePoints[2]);

                // See if we also have two line points.
                if (LinePoints.Count == 2)
                {
                    // Find the intersection.
                    Intersections = FindLineCircleIntersections(
                        CirclePoints[0], CirclePoints[1], CirclePoints[2],
                        LinePoints[0], LinePoints[1]);
                }
            }

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
            foreach (Point point in CirclePoints)
                e.Graphics.DrawEllipse(Pens.Red,
                    point.X - r, point.Y - r, 2 * r, 2 * r);
            foreach (Point point in LinePoints)
                e.Graphics.DrawEllipse(Pens.Green,
                    point.X - r, point.Y - r, 2 * r, 2 * r);

            // Draw the circle.
            if (CirclePoints.Count == 3)
                e.Graphics.DrawEllipse(Pens.Red, Circle);

            // Draw the line.
            if (LinePoints.Count == 2)
            {
                // Draw the line dashed.
                float dx = LinePoints[1].X - LinePoints[0].X;
                float dy = LinePoints[1].Y - LinePoints[0].Y;
                float length = (float)Math.Sqrt(dx * dx + dy * dy);
                float desired = Math.Max(
                    circlePictureBox.Width,
                    circlePictureBox.Height);
                dx *= 2 * desired / length;
                dy *= 2 * desired / length;
                PointF p0 = new PointF(
                    LinePoints[0].X - dx,
                    LinePoints[0].Y - dy);
                PointF p1 = new PointF(
                    LinePoints[0].X + dx,
                    LinePoints[0].Y + dy);
                using (Pen dashedPen = new Pen(Color.Green, 0))
                {
                    dashedPen.DashPattern = new float[] { 4, 4 };
                    e.Graphics.DrawLine(dashedPen, p0, p1);
                }

                using (Pen thickPen = new Pen(Color.Green, 2))
                {
                    // Draw the segment solid.
                    e.Graphics.DrawLine(thickPen, LinePoints[0], LinePoints[1]);
                }
            }

            // Draw the points of intersection.
            foreach (PointF point in Intersections)
                e.Graphics.DrawEllipse(Pens.Blue,
                    point.X - r, point.Y - r, 2 * r, 2 * r);
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

        // Find the point of intersection between a circle defined by
        // points p0, p1, p2 and the line define by points l0, l1.
        private List<PointF> FindLineCircleIntersections(
            PointF c0, PointF c1, PointF c2,
            PointF p0, PointF p1)
        {
            // Make a list to hold the points of intersection.
            List<PointF> results = new List<PointF>();

            // Find the circle.
            RectangleF circleRect = FindCircle(c0, c1, c2);

            // If the points don't define a circle, return the empty results list.
            if (circleRect.Width < 0) return results;

            // Get the circle's center and radius.
            float radius = circleRect.Width / 2;
            PointF c = new PointF(
                circleRect.X + radius,
                circleRect.Y + radius);

            // Find the intersection.
            float vx = p1.X - p0.X;
            float vy = p1.Y - p0.Y;
            float A = vx * vx + vy * vy;
            float B = 2 * (vx * (p0.X - c.X) + vy * (p0.Y - c.Y));
            float C =
                (p0.X - c.X) * (p0.X - c.X) +
                (p0.Y - c.Y) * (p0.Y - c.Y) -
                radius * radius;

            float discriminant = B * B - 4 * A * C;
            if (discriminant < 0)
            {
                Console.WriteLine("No real solutions");
                return results;
            }

            if (Math.Abs(discriminant) < 0.0001)
            {
                Console.WriteLine("One solution");
                float t = -B / (2 * A);
                results.Add(new PointF(
                    p0.X + t * vx,
                    p0.Y + t * vy));
            }
            else
            {
                Console.WriteLine("Two solutions");
                float root = (float)Math.Sqrt(discriminant);

                float t0 = (-B + root) / (2 * A);
                results.Add(new PointF(
                    p0.X + t0 * vx,
                    p0.Y + t0 * vy));

                float t1 = (-B - root) / (2 * A);
                results.Add(new PointF(
                    p0.X + t1 * vx,
                    p0.Y + t1 * vy));
            }

            return results;
        }
    }
}
