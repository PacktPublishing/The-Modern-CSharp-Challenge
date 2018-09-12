using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace SharksAndFish
{
    class Fish : Animal
    {
        public int TimeUntilBreeding { get; set; }
        public static Color Color = Color.White;

        public Fish(Ocean ocean, int breedingTime, int x, int y)
            : base(ocean, Color, x, y)
        {
            TimeUntilBreeding = 1 + Rand.Next(Ocean.FishBreedingTime);
        }
        public Fish(Ocean ocean, int breedingTime)
            : this(ocean, breedingTime,
                  Rand.Next(ocean.Width), Rand.Next(ocean.Height))
        {
        }

        public override void Move()
        {
            // Look for a free spot.
            List<Point> spots = Ocean.FreeSpots(X, Y, true);
            if (spots.Count > 0)
            {
                // Move.
                Ocean.Bitmap.SetPixel(X, Y, Color.Black);
                Ocean.Grid[X, Y] = null;

                Point moveTo = spots.Random();
                X = moveTo.X;
                Y = moveTo.Y;
                Ocean.Bitmap.SetPixel(X, Y, Fish.Color);
                Ocean.Grid[X, Y] = this;
            }

            // Breed.
            Breed();
        }

        // See if we should breed.
        private void Breed()
        {
            if (--TimeUntilBreeding > 0) return;

            // Breed.
            TimeUntilBreeding = Ocean.FishBreedingTime;

            // Position a child.
            List<Point> spots = Ocean.FreeSpots(X, Y, false);
            if (spots.Count == 0) return;

            Point childSpot = spots.Random();
            Ocean.Fishes.Add(new Fish(Ocean, Ocean.FishBreedingTime, childSpot.X, childSpot.Y));
        }
    }
}
