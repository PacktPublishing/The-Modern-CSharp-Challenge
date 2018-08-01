using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswords
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

        // Pick the indicated number of random items.
        public static T[] ChooseGroup<T>(this T[] values, int number)
        {
            // Make an array holding indices 0, 1, 2, ..., numValues - 1.
            int numItems = values.Length;
            int[] indices = Enumerable.Range(0, numItems).ToArray();

            // Partly randomize the indices array.
            if (number > numItems) number = numItems;
            for (int i = 0; i < number; i++)
            {
                // Pick a later item to swap into position i.
                int j = Rand.Next(i, numItems);

                // Swap items i and j.
                int temp = indices[i];
                indices[i] = indices[j];
                indices[j] = temp;
            }

            // Build the result array.
            T[] results = new T[number];
            for (int i = 0; i < number; i++) results[i] = values[indices[i]];
            return results;
        }

        // Pick the indicated number of random items.
        public static List<T> ChooseGroup<T>(this List<T> values, int number)
        {
            // Make an array holding indices 0, 1, 2, ..., numValues - 1.
            int numItems = values.Count;
            int[] indices = Enumerable.Range(0, numItems).ToArray();

            // Partly randomize the indices array.
            if (number > numItems) number = numItems;
            for (int i = 0; i < number; i++)
            {
                // Pick a later item to swap into position i.
                int j = Rand.Next(i, numItems);

                // Swap items i and j.
                int temp = indices[i];
                indices[i] = indices[j];
                indices[j] = temp;
            }

            // Build the result array.
            List<T> results = new List<T>();
            for (int i = 0; i < number; i++) results.Add(values[indices[i]]);
            return results;
        }

        // Return a random value where the values have the indicated probabilities.
        // The probabilities must add up to 1.0.
        public static T PickWithProbability<T>(this T[] values, double[] probabilities)
        {
            // Pick a random probability.
            double prob = Rand.NextDouble();

            // Find the selected item.
            for (int i = 0; i < values.Length; i++)
            {
                prob -= probabilities[i];
                if (prob <= 0) return values[i];
            }

            throw new Exception("Probabilities do not add up to 1.0");
        }

        // Return a random value where the values have the indicated probabilities.
        // The probabilities must add up to 1.0.
        public static T PickWithProbability<T>(this List<T> values, double[] probabilities)
        {
            // Pick a random probability.
            double prob = Rand.NextDouble();

            // Find the selected item.
            for (int i = 0; i < values.Count; i++)
            {
                prob -= probabilities[i];
                if (prob <= 0) return values[i];
            }

            throw new Exception("Probabilities do not add up to 1.0");
        }
    }
}
