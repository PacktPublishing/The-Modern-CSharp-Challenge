using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharksAndFish
{
    public static class RandomExtensions
    {
        private static Random Rand = new Random();

        // Pick a random item from a list.
        public static T Random<T>(this List<T> values)
        {
            return values[Rand.Next(values.Count)];
        }
    }
}
