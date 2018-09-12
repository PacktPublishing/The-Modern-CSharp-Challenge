using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Drawing2D;

namespace SpaceForce
{
    class Ship : Sprite
    {
        // The ship's direction in degrees. (Initially right.)
        public float Heading = 0;

        // Points to draw the ship at the origin pointing up.
        private PointF[] Points;

        // Constructor.
        private const float ShipRadius = 10;
        public Ship(Rectangle spaceBounds)
            : base(new RectangleF(
                spaceBounds.X + spaceBounds.Width / 2 - ShipRadius,
                spaceBounds.Y + spaceBounds.Height / 2 - ShipRadius,
                2 * ShipRadius, 2 * ShipRadius),
                    new PointF(), Brushes.Silver)
        {
            // Define the points used to draw the ship when Heading = 0.
            Points = new PointF[]
            {
                new PointF(-ShipRadius / 2, 0),
                new PointF(-ShipRadius, -ShipRadius),
                new PointF(ShipRadius, 0),
                new PointF(-ShipRadius, ShipRadius),
            };
        }

        // Draw.
        public override void Draw(Graphics gr)
        {
            if (IsDestroyed)
            {
                // Draw an explosion.
                gr.DrawImage(Properties.Resources.boom, Bounds);
            }
            else
            {
                // Draw a normal ship.
                // Transform to rotate and position the ship.
                GraphicsState state = gr.Save();
                gr.RotateTransform(Heading);
                gr.TranslateTransform(
                    Bounds.X + Bounds.Width / 2,
                    Bounds.Y + Bounds.Height / 2,
                    MatrixOrder.Append);
                gr.FillPolygon(Brush, Points);
                gr.Restore(state);
            }
        }

        // Accelerate.
        public void Accelerate()
        {
            const float accceleration = 0.5f;
            double radians = Heading * Math.PI / 180;
            Velocity.X += (float)(accceleration * Math.Cos(radians));
            Velocity.Y += (float)(accceleration * Math.Sin(radians));
        }

        // Turn left.
        private const float TurnDegrees = 6;
        public void TurnLeft()
        {
            Heading -= TurnDegrees;
        }

        // Turn right.
        public void TurnRight()
        {
            Heading += TurnDegrees;
        }

        // Return the position of the ship's nose.
        public PointF NosePosition()
        {
            PointF center = Bounds.Center();
            double radians = Heading * Math.PI / 180;
            double x = center.X + ShipRadius * Math.Cos(radians);
            double y = center.Y + ShipRadius * Math.Sin(radians);
            return new PointF((int)x, (int)y);
        }

        // Make a bullet moving out of the ship's nose.
        public Bubble MakeBullet()
        {
            const int bulletSpeed = 10;
            const int bulletR = 2;
            double radians = Heading * Math.PI / 180;
            PointF velocity = new PointF(
                (int)(bulletSpeed * Math.Cos(radians)),
                (int)(bulletSpeed * Math.Sin(radians)));
            PointF nose = NosePosition();
            RectangleF bulletRect = new RectangleF(
                nose.X - bulletR, nose.Y - bulletR, 2 * bulletR, 2 * bulletR);
            return new Bubble(bulletRect, velocity, Brushes.White);
        }
    }
}
