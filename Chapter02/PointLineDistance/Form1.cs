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

namespace PointLineDistance
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
                ClosestPoint = PointLineClosestPoint(
                    ThePoint, LeftClicks[0], LeftClicks[1]);

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

            // Draw the line.
            if (LeftClicks.Count == 2)
            {
                int vx = LeftClicks[1].X - LeftClicks[0].X;
                int vy = LeftClicks[1].Y - LeftClicks[0].Y;
                Point p0 = new Point(
                    LeftClicks[0].X - 1000 * vx,
                    LeftClicks[0].Y - 1000 * vy);
                Point p1 = new Point(
                    LeftClicks[0].X + 1000 * vx,
                    LeftClicks[0].Y + 1000 * vy);
                e.Graphics.DrawLine(Pens.Red, p0, p1);
            }

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
        private PointF PointLineClosestPoint(PointF p, PointF p0, PointF p1)
        {
            float vx = p1.X - p0.X;
            float vy = p1.Y - p0.Y;
            float numerator = vx * (p.X - p0.X) + vy * (p.Y - p0.Y);
            float denominator = vx * vx + vy * vy;
            float t = numerator / denominator;
            return new PointF(p0.X + t * vx, p0.Y + t * vy);
        }
    }
}
