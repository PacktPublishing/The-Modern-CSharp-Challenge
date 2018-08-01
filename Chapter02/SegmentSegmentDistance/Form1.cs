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

namespace SegmentSegmentDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Point> LeftClicks = new List<Point>();
        private List<Point> RightClicks = new List<Point>();
        private PointF LeftClosestPoint = new PointF(-1, -1);
        private PointF RightClosestPoint = new PointF(-1, -1);

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

            // If we have four points, find the closest points and distance.
            if ((LeftClicks.Count == 2) && (RightClicks.Count == 2))
            {
                // Find the closest points.
                bool isOnSegment0, isOnSegment1;
                SegmentSegmentClosestPoints(
                    LeftClicks[0], LeftClicks[1],
                    RightClicks[0], RightClicks[1],
                    out LeftClosestPoint, out RightClosestPoint,
                    out isOnSegment0, out isOnSegment1);

                // Display the distance.
                double distance = Math.Sqrt(DistanceSquared(
                    LeftClosestPoint, RightClosestPoint));
                distanceLabel.Text = distance.ToString("0.00");
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

            // Draw the segments.
            if (LeftClicks.Count == 2)
                e.Graphics.DrawLine(Pens.Red, LeftClicks[0], LeftClicks[1]);
            if (RightClicks.Count == 2)
                e.Graphics.DrawLine(Pens.Green, RightClicks[0], RightClicks[1]);

            // Draw the closest point.
            if ((LeftClicks.Count == 2) && (RightClicks.Count == 2))
            {
                // Draw the closest points.
                e.Graphics.DrawEllipse(Pens.Blue,
                    LeftClosestPoint.X - r, LeftClosestPoint.Y - r,
                    2 * r, 2 * r);
                e.Graphics.DrawEllipse(Pens.Blue,
                    RightClosestPoint.X - r, RightClosestPoint.Y - r,
                    2 * r, 2 * r);

                // Draw the segment between the closest points.
                using (Pen pen = new Pen(Color.Blue, 0))
                {
                    pen.DashPattern = new float[] { 4, 4 };
                    e.Graphics.DrawLine(pen, LeftClosestPoint, RightClosestPoint);
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

        // Find the point of intersection between the lines p00-p01 and p10-p11.
        private PointF IntersectLines(PointF p00, PointF p01, PointF p10, PointF p11,
            out bool isOnSegment0, out bool isOnSegment1)
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
                isOnSegment0 = false;
                isOnSegment1 = false;
                return new PointF(-1, -1);
            }
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

            isOnSegment0 = ((t0 >= 0) && (t0 <= 1));
            isOnSegment1 = ((t1 >= 0) && (t1 <= 1));

            return p0;
        }

        // Find the points where the segments p00-p01 and p10-p11 are closest.
        private void SegmentSegmentClosestPoints(
            PointF p00, PointF p01, PointF p10, PointF p11,
            out PointF closestPoint0, out PointF closestPoint1,
            out bool isOnSegment0, out bool isOnSegment1)
        {
            closestPoint0 = new PointF(-1, -1);
            closestPoint1 = new PointF(-1, -1);
            isOnSegment0 = false;
            isOnSegment1 = false;

            // Look for an intersection.
            PointF intersection = IntersectLines(p00, p01, p10, p11,
                out isOnSegment0, out isOnSegment1);
            if (isOnSegment0 && isOnSegment1)
            {
                closestPoint0 = intersection;
                closestPoint1 = intersection;
                return;
            }

            // See which segment end points are closest to the other segment.
            float testDist, bestDist = float.MaxValue;
            PointF testPoint;
            bool testIsOnSegment;

            // Check p00.
            testPoint = PointSegmentClosestPoint(p00,
                p10, p11, out testIsOnSegment);
            testDist = DistanceSquared(p00, testPoint);
            if (testDist < bestDist)
            {
                closestPoint0 = p00;
                closestPoint1 = testPoint;
                isOnSegment0 = true;
                isOnSegment1 = testIsOnSegment;
                bestDist = testDist;
            }

            // Check p01.
            testPoint = PointSegmentClosestPoint(p01,
                p10, p11, out testIsOnSegment);
            testDist = DistanceSquared(p01, testPoint);
            if (testDist < bestDist)
            {
                closestPoint0 = p01;
                closestPoint1 = testPoint;
                isOnSegment0 = true;
                isOnSegment1 = testIsOnSegment;
                bestDist = testDist;
            }

            // Check p10.
            testPoint = PointSegmentClosestPoint(p10,
                p00, p01, out testIsOnSegment);
            testDist = DistanceSquared(p10, testPoint);
            if (testDist < bestDist)
            {
                closestPoint0 = testPoint;
                closestPoint1 = p10;
                isOnSegment0 = testIsOnSegment;
                isOnSegment1 = true;
                bestDist = testDist;
            }

            // Check p11.
            testPoint = PointSegmentClosestPoint(p11,
                p00, p01, out testIsOnSegment);
            testDist = DistanceSquared(p11, testPoint);
            if (testDist < bestDist)
            {
                closestPoint0 = testPoint;
                closestPoint1 = p11;
                isOnSegment0 = testIsOnSegment;
                isOnSegment1 = true;
                bestDist = testDist;
            }
        }

        // Return the distance squared between two points.
        private float DistanceSquared(PointF p0, PointF p1)
        {
            float dx = p0.X - p1.X;
            float dy = p0.Y - p1.Y;
            return dx * dx + dy * dy;
        }
    }
}
