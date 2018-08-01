using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeItems
{
    public static class RandomExtensions
    {
        // A Random objects shared by all extensions.
        private static Random Rand = new Random();

        // Return a double between minValue and maxValue.
        public static double NextDouble(this Random rand, double minValue, double maxValue)
        {
            return minValue + Rand.NextDouble() * (maxValue - minValue);
        }

        // Return a random object selected from the array.
        public static T Random<T>(this T[] values)
        {
            return values[Rand.Next(0, values.Length)];
        }

        // Return a random object selected from the list.
        public static T Random<T>(this List<T> values)
        {
            return values[Rand.Next(0, values.Count)];
        }

        // Randomize the array in place.
        public static void Randomize<T>(this T[] values)
        {
            int numItems = values.Length;

            // Pick a random item for each position.
            for (int i = 0; i < numItems - 1; i++)
            {
                // Pick a later item to swap into position i.
                int j = Rand.Next(i, numItems);

                // Swap items i and j.
                T temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }

        // Randomize the list in place.
        public static void Randomize<T>(this List<T> values)
        {
            int numItems = values.Count;

            // Pick a random item for each position.
            for (int i = 0; i < numItems - 1; i++)
            {
                // Pick a later item to swap into position i.
                int j = Rand.Next(i, numItems);

                // Swap items i and j.
                T temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }
    }
}
