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

namespace PointSegmentDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Point> LeftClicks = new List<Point>();
        private Point ThePoint = new Point(-1, -1);
        private PointF ClosestPoint = new PointF(-1, -1);

        private void linesPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // If we already have two points, clear the appropriate point list.
            // Then save the new point.
            if (e.Button == MouseButtons.Left)
            {
                if (LeftClicks.Count == 2) LeftClicks = new List<Point>();
                LeftClicks.Add(e.Location);
            }
            else ThePoint = e.Location;

            // If we have three points, find the closest point and distance.
            if ((LeftClicks.Count == 2) &&
                (ThePoint.X >= 0) && (ThePoint.Y >= 0))
            {
                // Find the closest point.
                bool isOnSegment;
                ClosestPoint = PointSegmentClosestPoint(
                    ThePoint, LeftClicks[0], LeftClicks[1], out isOnSegment);

                // Display the distance.
                float dx = ThePoint.X - ClosestPoint.X;
                float dy = ThePoint.Y - ClosestPoint.Y;
                double distance = Math.Sqrt(dx * dx + dy * dy);
                distanceLabel.Text = distance.ToString("0.00");
            }
            else
                ClosestPoint = new PointF(-1, -1);

            linesPictureBox.Refresh();
        }

        // Draw whatever we have.
        private void linesPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the selected points.
            const int r = 3;
            foreach (Point point in LeftClicks)
                e.Graphics.DrawEllipse(Pens.Red,
                    point.X - r, point.Y - r, 2 * r, 2 * r);
            e.Graphics.FillEllipse(Brushes.Green,
                ThePoint.X - r, ThePoint.Y - r, 2 * r, 2 * r);

            // Draw the segment.
            if (LeftClicks.Count == 2)
                e.Graphics.DrawLine(Pens.Red, LeftClicks[0], LeftClicks[1]);

            // Draw the closest point.
            if ((ClosestPoint.X >= 0) && (ClosestPoint.Y >= 0))
            {
                // Draw the closest point.
                e.Graphics.DrawEllipse(Pens.Blue,
                    ClosestPoint.X - r, ClosestPoint.Y - r, 2 * r, 2 * r);

                // Draw the segment between the user's point and the closest point.
                using (Pen pen = new Pen(Color.Blue, 0))
                {
                    pen.DashPattern = new float[] { 4, 4 };
                    e.Graphics.DrawLine(pen, ClosestPoint, ThePoint);
                }
            }
        }

        // Find the point on the line p0-p1 that is closest to point p.
        private PointF PointSegmentClosestPoint(PointF p, PointF p0, PointF p1, out bool isOnSegment)
        {
            float vx = p1.X - p0.X;
            float vy = p1.Y - p0.Y;
            float numerator = vx * (p.X - p0.X) + vy * (p.Y - p0.Y);
            float denominator = vx * vx + vy * vy;
            float t = numerator / denominator;

            // See if the point is on the segment.
            isOnSegment = ((t >= 0) && (t <= 1));
            if (isOnSegment) return new PointF(p0.X + t * vx, p0.Y + t * vy);

            // The point we found is not on the segment.
            // See which endpoint is closer.
            float dx0 = p.X - p0.X;
            float dy0 = p.Y - p0.Y;
            float dist0squared = dx0 * dx0 + dy0 * dy0;

            float dx1 = p.X - p1.X;
            float dy1 = p.Y - p1.Y;
            float dist1squared = dx1 * dx1 + dy1 * dy1;

            if (dist0squared <= dist1squared) return p0;
            return p1;
        }
    }
}
