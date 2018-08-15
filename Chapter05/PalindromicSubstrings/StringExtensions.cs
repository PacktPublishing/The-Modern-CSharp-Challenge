using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicSubstrings
{
    public static class StringExtensions
    {
        // Return the string with punctuation removed.
        public static string RemovePunctuation(this string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in input)
                if (!char.IsPunctuation(ch))
                    sb.Append(ch);
            return sb.ToString();
        }

        // Return the longest palindromic substring in this string.
        public static string LongestPalindromicSubstring(this string input)
        {
            // Remove punctuation and spaces and convert to uppercase.
            input = input.RemovePunctuation().Replace(" ", "").ToUpper();

            // Start with the first character as the longest palindromic substring.
            string bestPal = input.Substring(0, 1);
            int bestLength = 1;

            // Look for odd-length palindromes.
            int inputLength = input.Length;
            for (int i = 1; i < inputLength; i++)
            {
                string testPal = LongestPalAt(input, i, i);
                if (testPal.Length > bestLength)
                {
                    bestPal = testPal;
                    bestLength = bestPal.Length;
                }
            }

            // Look for even-length palindromes.
            for (int i = 1; i < inputLength; i++)
            {
                string testPal = LongestPalAt(input, i - 1, i);
                if (testPal.Length > bestLength)
                {
                    bestPal = testPal;
                    bestLength = bestPal.Length;
                }
            }

            return bestPal;
        }

        // Return the longest palindromic substring with center between start and end.
        private static string LongestPalAt(string input, int start, int end)
        {
            while ((start >= 0) && (end < input.Length) &&
                (input[start] == input[end]))
            {
                start--;
                end++;
            }
            return input.Substring(start + 1, end - start - 1);
        }
    }
}
