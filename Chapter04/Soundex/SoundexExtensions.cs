using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundex
{
    public static class SoundexExtensions
    {
        // Digits for characters.
        private static string LetterCodes =
            "01230120022455012623010202";

        // Return an American Soundex encoding.
        public static string ToSoundex(this string name)
        {
            if (name == "") return "";

            // Convert to all caps.
            name = name.ToUpper();

            // Remove H and W after the first letter.
            name = name[0] + name.Substring(1).Replace("H", "").Replace("W", "");

            // Encode the letters.
            char lastDigit = 'x';
            string encoding = "";
            foreach (char ch in name)
            {
                // Get the encoding for this letter.
                char newDigit = LetterCodes[ch - 'A'];

                // If this is the same as the previous code, ignore it.
                if (lastDigit != newDigit)
                {
                    encoding += newDigit;
                    lastDigit = newDigit;
                }
            }

            // Remove the first digit from the encoding.
            encoding = encoding.Substring(1);

            // Remove the vowels from the encoding.
            encoding = encoding.Replace("0", "");

            // Pad or truncate if necessary.
            if (encoding.Length < 3) encoding = encoding.PadRight(3, '0');
            else if (encoding.Length > 3) encoding = encoding.Substring(0, 3);

            // Add the original name's letter at the beginning and return.
            return name[0] + encoding;
        }
    }
}
