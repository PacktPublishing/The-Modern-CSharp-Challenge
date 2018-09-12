using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SpaceForce
{
    public static class RectangleExtensions
    {
        // Return the rectangle's center.
        public static PointF Center(this RectangleF rect)
        {
            return new PointF(
                rect.X + rect.Width / 2f,
                rect.Y + rect.Height / 2f);
        }
        public static PointF Center(this Rectangle rect)
        {
            return new PointF(
                rect.X + rect.Width / 2f,
                rect.Y + rect.Height / 2f);
        }
    }
}
