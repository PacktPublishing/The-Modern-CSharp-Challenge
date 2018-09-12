using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SpaceForce
{
    public abstract class Sprite
    {
        // Position and velocity.
        public RectangleF Bounds;
        public PointF Velocity;

        // Brush. This should be a stock object.
        public Brush Brush = Brushes.Silver;

        // True if this sprite should be destroyed.
        public bool IsDestroyed = false;
        
        // Constructor.
        public Sprite(RectangleF position, PointF velocity, Brush brush)
        {
            Bounds = position;
            Velocity = velocity;
            Brush = brush;
        }

        // Move.
        public void Move(Rectangle spaceBounds, bool wrap = true)
        {
            // Update the position.
            Bounds.X += Velocity.X;
            Bounds.Y += Velocity.Y;

            // See if we should wrap around the sides of the bounds.
            if (wrap)
            {
                // If the sprite has left the space bounds, wrap around.
                if (Bounds.Right < spaceBounds.Left)        // Off left edge.
                    Bounds.X = spaceBounds.Right - 1;
                else if (Bounds.Left > spaceBounds.Right)   // Off right edge.
                    Bounds.X = spaceBounds.Left - Bounds.Width + 1;
                else if (Bounds.Top > spaceBounds.Bottom)   // Off bottom edge.
                    Bounds.Y = spaceBounds.Top - Bounds.Height + 1;
                else if (Bounds.Bottom < spaceBounds.Top)   // Off top edge.
                    Bounds.Y = spaceBounds.Bottom - 1;
            }
        }

        // Return true if the sprite is out of bounds.
        public bool IsOutOfBounds(Rectangle spaceBounds)
        {
            return (!Bounds.IntersectsWith(spaceBounds));
        }

        // Return true if the objects intersect.
        public bool IntersectsWith(Sprite other)
        {
            return (Bounds.IntersectsWith(other.Bounds));
        }

        // Draw the object.
        public abstract void Draw(Graphics gr);
    }
}
