using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytesToHex
{
    public static class ByteExtensions
    {
        // Convert a string into an array of bytes.
        public static byte[] StringToBytes(this string input)
        {
            UnicodeEncoding encoder = new UnicodeEncoding();
            return encoder.GetBytes(input);
        }

        // Convert the bytes into a string and return it.
        public static string BytesToString(this byte[] bytes)
        {
            UnicodeEncoding encoder = new UnicodeEncoding();
            return encoder.GetString(bytes);
        }

        // Convert from a byte array to a hex string.
        public static string BytesToHex(this byte[] bytes, char separator)
        {
            return BitConverter.ToString(bytes, 0).Replace('-', separator);
        }

        // Convert a string of hexadecimal values into a byte array.
        public static byte[] HexToBytes(this string theString)
        {
            // Get the separator character.
            char separator = theString[2];

            // Split at the separators.
            string[] pairs = theString.Split(separator);
            byte[] bytes = new byte[pairs.Length];
            for (int i = 0; i < pairs.Length; i++)
                bytes[i] = Convert.ToByte(pairs[i], 16);
            return bytes;
        }
    }
}
