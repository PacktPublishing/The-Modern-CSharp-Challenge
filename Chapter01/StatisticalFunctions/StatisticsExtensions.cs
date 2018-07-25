using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticalFunctions
{
    public static class StatisticsExtensions
    {
        // Return the truncated mean of an IEnumerable of numbers.
        // Set discardNumber to the number of values to discard at the
        // top and bottom. For example, set discardNumber = 5 to
        // discard the 5 largest and smallest values.
        public static double TruncatedMean<T>(this IEnumerable<T> values, int discardNumber)
        {
            // Convert the values into an enumerable of doubles.
            IEnumerable<double> doubles =
                values.Select(value => Convert.ToDouble(value));
            double[] doubleArray = doubles.ToArray();

            // Sort the doubles.
            Array.Sort(doubleArray);

            // Find the values that we want to use.
            int minIndex = discardNumber;
            int maxIndex = doubleArray.Length - 1 - discardNumber;

            // Copy the desired items into a new array.
            int numRemaining = maxIndex - minIndex + 1;
            double[] remainingItems = new double[numRemaining];
            Array.Copy(doubleArray, minIndex, remainingItems, 0, numRemaining);

            // Calculate and return the truncated mean.
            return remainingItems.Average();
        }

        // Return the truncated mean of an IEnumerable of numbers.
        // Set discardFraction to the fraction of values to discard at the
        // top and bottom. For example, set discardFraction = 0.05 to
        // discard the 5% largest and smallest values.
        public static double TruncatedMean<T>(this IEnumerable<T> values, double discardFraction)
        {
            // Calculate the number of items to remove at the top and bottom.
            int discardNumber = (int)(values.Count() * discardFraction);

            // Invoke the previous version of TruncatedMean.
            return TruncatedMean(values, discardNumber);
        }

        // Return the median of an IEnumerable of numbers.
        public static double Median<T>(this IEnumerable<T> values)
        {
            // Convert into an enumerable of doubles.
            IEnumerable<double> doubles =
                values.Select(value => Convert.ToDouble(value));
            double[] doubleArray = doubles.ToArray();

            // Sort the doubles.
            Array.Sort(doubleArray);

            // Calculate and return the median.
            int numValues = doubleArray.Length;
            if (numValues % 2 == 1)
            {
                // There are an odd number of values.
                // Return the middle one.
                return doubleArray[numValues / 2];
            }

            // Return the mean of the two middle values.
            double value1 = doubleArray[numValues / 2 - 1];
            double value2 = doubleArray[numValues / 2];
            return (value1 + value2) / 2.0;
        }

        // Return the mode(s) of an IEnumerable of numbers.
        public static List<T> Modes<T>(this IEnumerable<T> values)
        {
            // Make a dictionary to hold value counts.
            Dictionary<T, int> counts = new Dictionary<T, int>();

            // Count the values.
            foreach (T value in values)
            {
                if (!counts.ContainsKey(value))
                    counts.Add(value, 1);
                else
                    counts[value]++;
            }

            // Find the largest count.
            int largestCount = counts.Values.Max();

            // Find the value(s) with that count.
            List<T> modes = new List<T>();
            foreach (KeyValuePair<T, int> pair in counts)
                if (pair.Value == largestCount) modes.Add(pair.Key);
            return modes;
        }

        // Return the standard deviation of an IEnumerable of numbers.
        //
        // If the second argument is True, evaluate as a sample.
        // If the second argument is False, evaluate as a population.
        public static double StdDev<T>(this IEnumerable<T> values,
            bool asSample = false)
        {
            // Convert into an enumerable of doubles.
            IEnumerable<double> doubles =
                values.Select(value => Convert.ToDouble(value));

            // Get the number of items and the mean.
            int numValues = doubles.Count();
            double mean = doubles.Average();

            // Get the sum of the squares of the differences
            // between the values and the mean.
            var squaresQuery =
                from double value in doubles
                select (value - mean) * (value - mean);
            double sumOfSquares = squaresQuery.Sum();

            // Return the apppropriate type of standard deviation.
            if (asSample)
                return Math.Sqrt(sumOfSquares / (numValues - 1));
            return Math.Sqrt(sumOfSquares / numValues);
        }
    }
}
