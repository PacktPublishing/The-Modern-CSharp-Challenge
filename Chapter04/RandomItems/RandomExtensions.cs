using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomItems
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
    }
}
