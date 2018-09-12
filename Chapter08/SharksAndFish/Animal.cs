using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SharksAndFish
{
    class Animal
    {
        protected static Random Rand = new Random();

        public Ocean Ocean { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        // Position this animal.
        public Animal(Ocean ocean, Color color, int x, int y)
        {
            Ocean = ocean;
            X = x;
            Y = y;
            Ocean.Grid[X, Y] = this;
            Ocean.Bitmap.SetPixel(X, Y, color);
        }

        // Initialize the location randomly.
        public Animal(Ocean ocean, Color color)
            : this(ocean, color, Rand.Next(ocean.Width), Rand.Next(ocean.Height))
        {
        }

        // Move the animal.
        public virtual void Move() { }
    }
}
