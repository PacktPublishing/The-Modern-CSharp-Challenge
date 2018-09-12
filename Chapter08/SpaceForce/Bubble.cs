using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForce
{
    class Bubble : Sprite
    {
        // Constructor.
        public Bubble(RectangleF position, PointF velocity, Brush brush)
            : base(position, velocity, brush)
        {
        }

        // Draw.
        public override void Draw(Graphics gr)
        {
            gr.FillEllipse(Brush, Bounds);
            gr.DrawEllipse(Pens.Black, Bounds);
        }

        // Used for making random bubbles.
        private static Random Rand = new Random();

        // Possible bubble brushes and pens.
        private static Brush[] BubbleBrushes =
        {
            Brushes.Red, Brushes.Green, Brushes.Blue,
            Brushes.Pink, Brushes.LightGreen, Brushes.LightBlue,
            Brushes.Yellow, Brushes.Orange, Brushes.Fuchsia,
            Brushes.Cyan,
        };

        // Factory method to make a random bubble
        // near the edges of the allowed rectangle.
        public static Bubble RandomBubble(Rectangle spaceBounds)
        {
            // Get random Bubble properties.
            int diameter = Rand.Next(20, 60);
            PointF center = spaceBounds.Center();
            PointF point;
            do
            {
                int px = Rand.Next(0, spaceBounds.Width - diameter);
                int py = Rand.Next(0, spaceBounds.Height - diameter);
                point = new PointF(px, py);
            } while (Distance(center, point) < 150);

            int speed = Rand.Next(3, 7);
            double angle = Rand.Next(0, 360) * Math.PI / 180.0;
            double vx = speed * Math.Cos(angle);
            double vy = speed * Math.Sin(angle);
            Brush brush = BubbleBrushes[Rand.Next(0, BubbleBrushes.Length)];

            RectangleF rect = new RectangleF(point.X, point.Y, diameter, diameter);
            return new Bubble(rect, new PointF((int)vx, (int)vy), brush);
        }

        // Return the distance between the two points.
        private static double Distance(PointF point1, PointF point2)
        {
            float dx = point1.X - point2.X;
            float dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
