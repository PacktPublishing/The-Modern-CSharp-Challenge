using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovePunctuation
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
    }
}
