using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.Numerics;

namespace CPRNG
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
            text = new string(text.Where(ch => !char.IsPunctuation(ch)).ToArray());
            text = new string(text.Where(ch => !char.IsWhiteSpace(ch)).ToArray());
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

        // Use a Vigenere cipher to encrypt plaintext.
        private static string VigenereEncryptDecrypt(this string plaintext, string key, bool decrypt)
        {
            key = key.StripText();
            plaintext = plaintext.StripText();

            // Encrypt.
            char[] chars = new char[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                int shift = key[i % key.Length] - 'A';
                if (decrypt) shift = -shift;

                int ch = plaintext[i] - 'A';
                ch = (ch + shift + 26) % 26;
                chars[i] = (char)('A' + ch);
            }

            return new string(chars).ToFiveGrams();
        }

        // Use a Vigenere cipher to encrypt the ciphertext.
        public static string VigenereEncrypt(this string plaintext, string key)
        {
            return VigenereEncryptDecrypt(plaintext, key, false);
        }

        // Use a Vigenere cipher to decrypt the ciphertext.
        public static string VigenereDecrypt(this string plaintext, string key)
        {
            return VigenereEncryptDecrypt(plaintext, key, true);
        }

        #region Random Numbers

        // Generate a cryptographically secure long in [minValue, maxValue).
        public static long NextLong(long minValue, long maxValue)
        {
            // The biggest value we can create with 16 bytes.
            BigInteger biggest = BigInteger.Pow(2, 8 * 16) - 1;

            // Calculate the number of values in [maxValue, minValue).
            long numValues = maxValue - minValue;

            // The amount of unused space at the end of the biggest range.
            BigInteger numUnused = (biggest + 1) % numValues;

            // The largest usable value.
            BigInteger maxUsable = biggest - numUnused;

            // Generate random BigIntegers until we get one between 0 and maxUsable.
            byte[] bytes = new byte[16];
            for (;;)
            {
                // Get a random BigInteger.
                BigInteger rand = RandomUBigInteger(16);

                // If the value is within the allowed range, use it.
                if (rand <= maxUsable)
                    return (long)(minValue + (rand % numValues));
            }
        }

        // A cryptographic pseudorandom number provider.
        private static RNGCryptoServiceProvider Cprng =
            new RNGCryptoServiceProvider();

        // Return a cryptographically secure random unsigned
        // BigInteger with the indicated number of bytes.
        private static BigInteger RandomUBigInteger(int numBytes)
        {
            // Get the random bytes.
            byte[] bytes = new byte[numBytes];
            Cprng.GetBytes(bytes);

            // Convert the bytes into an unsigned value;
            BigInteger result = 0;
            BigInteger factor = 1;
            for (int i = 0; i < numBytes; i++)
            {
                result += factor * bytes[i];
                factor *= 256;
            }
            return result;
        }

        // Test method to test the ideas described in the book where the
        // random number generator produces values in [0, 10).
        // Be sure to test with minValue = 0 and maxValue 8
        // or other small values that fit in [0, 10).
        private static Random Rand = new Random();

        // Use Random.Rand(0, 10) to generate a number in [minValue, maxValue).
        public static long NextValue(long minValue, long maxValue)
        {
            // The biggest value we can create.
            long biggest = 9;

            // Calculate the number of values in [maxValue, minValue).
            long numValues = maxValue - minValue;

            // The amount of unused space at the end of the biggest range.
            long numUnused = (biggest + 1) % numValues;

            // The largest usable value.
            long maxUsable = biggest - numUnused;

            // Generate values in [0, 10) until we get one between 0 and maxUsable.
            for (;;)
            {
                // Get a random value.
                long rand = Rand.Next(0, 10);

                // If the value is within the allowed range, use it.
                if (rand <= maxUsable)
                    return (long)(minValue + (rand % numValues));
            }
        }

        #endregion Random Numbers

    }
}
