using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class RomanExtensions
    {
        // Maps letters to numbers.
        private static Dictionary<char, long> LetterValues = null;

        // Convert Roman numerals into an integer.
        public static long ToArabic(this string roman)
        {
            // Initialize the letter lookup table if it hasn't been initialized yet.
            if (LetterValues == null)
            {
                LetterValues = new Dictionary<char, long>();
                LetterValues.Add('I', 1);
                LetterValues.Add('V', 5);
                LetterValues.Add('X', 10);
                LetterValues.Add('L', 50);
                LetterValues.Add('C', 100);
                LetterValues.Add('D', 500);
                LetterValues.Add('M', 1000);
            }

            // If this is a blank string, return 0.
            roman = roman.Trim();
            if (roman.Length == 0) return 0;
            roman = roman.ToUpper();

            // If the number begins with "(," break out the part inside the parentheses.
            if (roman[0] == '(')
            {
                // Find the last ")."
                int end = roman.LastIndexOf(')');

                // Get the value inside the parentheses.
                string part1 = roman.Substring(1, end - 1);
                string part2 = roman.Substring(end + 1);

                // Evaluate the part inside parentheses, multiply by 1,000, and add the rest.
                return 1000L * part1.ToArabic() + part2.ToArabic();
            }

            // At this point, we're down to plain digits. Evaluate them.
            long total = 0;
            long lastValue = 0;  // The value of the last letter.

            // Loop through letters right to left.
            for (int i = roman.Length - 1; i >= 0; i--)
            {
                // Get the next letter.
                long newValue = LetterValues[roman[i]];

                // If the new value is less than the previous one,
                // then subtract this one, as in IV.
                if (newValue < lastValue)
                    total -= newValue;
                else
                {
                    total += newValue;
                    lastValue = newValue;
                }
            }

            // Return the result.
            return total;
        }

        // Map digits to letters.
        private static string[] roman1000s = { "", "M", "MM", "MMM" };
        private static string[] roman100s = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static string[] roman10s = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static string[] roman1s = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        // Convert Arabic numerals into Roman numerals.
        public static string ToRoman(this long arabic)
        {
            // If it's >= 4,000, use parenthese.
            if (arabic >= 4000)
            {
                long thousands = arabic / 1000;
                arabic %= 1000;
                return "(" + thousands.ToRoman() + ")" + arabic.ToRoman();
            }

            // If it's < 4,000, process the letters.
            string result = "";

            // Thousands.
            long num;
            num = arabic / 1000;
            result += roman1000s[num];
            arabic %= 1000;

            // Hundreds.
            num = arabic / 100;
            result += roman100s[num];
            arabic %= 100;

            // Tens.
            num = arabic / 10;
            result += roman10s[num];
            arabic %= 10;

            // Ones.
            result += roman1s[arabic];

            return result;
        }
    }
}
