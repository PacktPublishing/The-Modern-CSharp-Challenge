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
using System.Diagnostics;

namespace LineLineIntersection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Point> LeftClicks = new List<Point>();
        private List<Point> RightClicks = new List<Point>();
        private PointF Intersection = new PointF(-1, -1);

        private void linesPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // If we already have two points, clear the appropriate point list.
            // Then save the new point.
            if (e.Button == MouseButtons.Left)
            {
                if (LeftClicks.Count == 2) LeftClicks = new List<Point>();
                LeftClicks.Add(e.Location);
            }
            else
            {
                if (RightClicks.Count == 2) RightClicks = new List<Point>();
                RightClicks.Add(e.Location);
            }

            // If we have four points, find the intersection.
            if ((LeftClicks.Count == 2) && (RightClicks.Count == 2))
            {
                try
                {
                    Intersection = IntersectLines(
                        LeftClicks[0], LeftClicks[1],
                        RightClicks[0], RightClicks[1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Intersection = new PointF(-1, -1);
                }
            }

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
            foreach (Point point in RightClicks)
                e.Graphics.DrawEllipse(Pens.Green,
                    point.X - r, point.Y - r, 2 * r, 2 * r);

            // Draw the lines.
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

            if (RightClicks.Count == 2)
            {
                int vx = RightClicks[1].X - RightClicks[0].X;
                int vy = RightClicks[1].Y - RightClicks[0].Y;
                Point p0 = new Point(
                    RightClicks[0].X - 1000 * vx,
                    RightClicks[0].Y - 1000 * vy);
                Point p1 = new Point(
                    RightClicks[0].X + 1000 * vx,
                    RightClicks[0].Y + 1000 * vy);
                e.Graphics.DrawLine(Pens.Green, p0, p1);
            }

            // Draw the point of intersection.
            if ((Intersection.X >= 0) && (Intersection.Y >= 0))
                e.Graphics.DrawEllipse(Pens.Blue,
                    Intersection.X - r, Intersection.Y - r, 2 * r, 2 * r);
        }

        // Find the point of intersection between the lines p00-p01 and p10-p11.
        private PointF IntersectLines(PointF p00, PointF p01, PointF p10, PointF p11)
        {
            // Get the segments' parameters.
            float v0x = p01.X - p00.X;
            float v0y = p01.Y - p00.Y;
            float v1x = p11.X - p10.X;
            float v1y = p11.Y - p10.Y;

            // Solve for t0 and t1.
            float denominator = v0y * v1x - v0x * v1y;

            float t0 = (v1y * (p00.X - p10.X) - v1x * (p00.Y - p10.Y)) / denominator;
            if (float.IsInfinity(t0)) throw new Exception("The lines are parallel");
            PointF p0 = new PointF(
                p00.X + t0 * v0x,
                p00.Y + t0 * v0y);

            // Check.
            float t1 = (v0y * (p10.X - p00.X) - v0x * (p10.Y - p00.Y)) / -denominator;
            PointF p1 = new PointF(
                p10.X + t1 * v1x,
                p10.Y + t1 * v1y);
            Debug.Assert(Math.Abs(p0.X - p1.X) < 0.0001);
            Debug.Assert(Math.Abs(p0.Y - p1.Y) < 0.0001);

            return p0;
        }
    }
}
