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

namespace IsConvex
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

                // Determine whether the polygon is convex.
                isConvexLabel.Text = PolygonIsConvex(PolygonPoints).ToString();
            }
            else
            {
                if (PolygonIsReady)
                {
                    // Start a new polygon.
                    PolygonIsReady = false;
                    PolygonPoints = new List<Point>();
                    isConvexLabel.Text = "";
                }

                // Add the point to the polygon.
                PolygonPoints.Add(e.Location);
            }

            polygonPictureBox.Refresh();
        }

        // Draw the polygon so far.
        private void polygonPictureBox_Paint(object sender, PaintEventArgs e)
        {
            const int gap = 3;

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

        // Return true if testPoint lies inside the polygon.
        private bool PointIsInPolygon(List<Point> points, Point testPoint)
        {
            int numPoints = points.Count;
            if (numPoints < 3)
                throw new Exception("The polygon must have at least three vertices");

            // Repeat the first point at the end for convenience.
            points.Add(points[0]);

            // Loop over the polygon's segments.
            float total = 0;
            for (int i = 0; i < numPoints; i++)
                total += GetAngle(points[i], testPoint, points[i + 1]);

            // Remove the repeated first point.
            points.RemoveAt(numPoints);

            // See if total is +/-2*pi.
            const float tiny = 0.0001f;
            return (Math.Abs(total) > tiny);
        }

        // Return the cross product AB x BC.
        // Note that |AB x BC| = |AB| * |BC| * Sin(theta).
        public static float CrossProductLength(Point A, Point B, Point C)
        {
            // Get the vectors' components.
            float ABx = A.X - B.X;
            float ABy = A.Y - B.Y;
            float BCx = C.X - B.X;
            float BCy = C.Y - B.Y;

            // Calculate the Z coordinate of the cross product.
            return (ABx * BCy - ABy * BCx);
        }

        // Return the dot product AB · BC.
        // Note that AB · BC = |AB| * |BC| * Cos(theta).
        private static float DotProduct(Point A, Point B, Point C)
        {
            // Get the vectors' components.
            float ABx = A.X - B.X;
            float ABy = A.Y - B.Y;
            float BCx = C.X - B.X;
            float BCy = C.Y - B.Y;

            // Calculate the dot product.
            return (ABx * BCx + ABy * BCy);
        }

        // Return angle ABC between PI and -PI.
        // Note that the value is the opposite of what you might
        // expect because Y coordinates increase downward.
        public static float GetAngle(Point A, Point B, Point C)
        {
            // Get the dot product.
            float dotProduct = DotProduct(A, B, C);

            // Get the cross product.
            float crossProduct = CrossProductLength(A, B, C);

            // Calculate the angle.
            return (float)Math.Atan2(crossProduct, dotProduct);
        }

        // Return true if the polygon is convex.
        private bool PolygonIsConvex(List<Point> points)
        {
            int numPoints = points.Count;
            if (numPoints < 3)
                throw new Exception("The polygon must have at least three vertices");

            // Duplicate the first two points.
            points.Add(points[0]);
            points.Add(points[1]);

            // Get the sign of the first angle.
            int sign = Math.Sign(GetAngle(points[0], points[1], points[2]));

            // Loop through the angles.
            bool isConvex = true;
            for (int i = 1; i < numPoints; i++)
            {
                if (Math.Sign(GetAngle(points[i], points[i + 1], points[i + 2])) != sign)
                {
                    isConvex = false;
                    break;
                }
            }

            // Remove the duplicates that we added.
            points.RemoveAt(numPoints);
            points.RemoveAt(numPoints);

            return isConvex;
        }
    }
}
