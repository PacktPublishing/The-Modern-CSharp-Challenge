using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public static class CryptoExtensions
    {
        // Use a Caesar cipher to encrypt the plaintext.
        public static string CaesarEncrypt(this string plaintext, int shift)
        {
            plaintext = plaintext.StripText();

            // Encrypt.
            char[] chars = new char[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                int ch = plaintext[i] - 'A';
                ch = (ch + shift + 26) % 26;
                chars[i] = (char)('A' + ch);
            }

            return new string(chars).ToFiveGrams();
        }

        // Use a Caesar cipher to decrypt the ciphertext.
        public static string CaesarDecrypt(this string ciphertext, int shift)
        {
            return ciphertext.CaesarEncrypt(-shift);
        }

        // Convert to uppercase, and remove punctuation and spaces.
        public static string StripText(this string text)
        {
            text = text.ToUpper();
            text = new string(text.Where(ch => (ch >= 'A') && (ch <= 'Z')).ToArray());
            return text;
        }

        // Separate the string into five-character pieces.
        public static string ToFiveGrams(this string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i += 5)
            {
                int length = Math.Min(5, text.Length - i);
                result.Append(" " + text.Substring(i, length));
            }
            result.Remove(0, 1);
            return result.ToString();
        }
    }
}
