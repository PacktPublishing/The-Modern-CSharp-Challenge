using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Steganography
{
    public static class BitmapExtensions
    {
        // The component where a bit should be stored.
        private enum RGB { R, G, B }

        #region Steg Methods

        // Return a copy of the bitmap with data embedded in it.
        public static Bitmap StegMessage(this Bitmap bm, string message)
        {
            // Make sure the image is big enough.
            byte[] messageBytes = Encoding.Unicode.GetBytes(message);
            int numMessageBytes = messageBytes.Length;
            byte[] lengthBytes = BitConverter.GetBytes(numMessageBytes);
            int numLengthBytes = lengthBytes.Length;
            int numMessageBits = 8 * (numMessageBytes + numLengthBytes);

            int numAvailableBits = 3 * bm.Width * bm.Height;
            if (numMessageBits > numAvailableBits)
                throw new IndexOutOfRangeException(
                    "The message is too big to fit in the image.\n" +
                    $"The message is {numMessageBits} bits long but " +
                    $"the image can hold only {numAvailableBits} bits.");

            // Hide the message length.
            Bitmap bmCopy = new Bitmap(bm);
            int x = 0, y = 0;
            RGB component = RGB.R;
            StegBytes(bmCopy, lengthBytes, ref x, ref y, ref component);

            // Hide the message bytes.
            StegBytes(bmCopy, messageBytes, ref x, ref y, ref component);

            // Return the bitmap.
            return bmCopy;
        }

        // Hide an array of bytes in the image.
        private static void StegBytes(Bitmap bm, byte[] bytes, ref int x, ref int y, ref RGB component)
        {
            foreach (byte aByte in bytes)
                StegByte(bm, aByte, ref x, ref y, ref component);
        }

        // Hide a byte in the image.
        private static void StegByte(Bitmap bm, byte aByte, ref int x, ref int y, ref RGB component)
        {
            byte mask = 0b00000001;
            for (int i = 0; i < 8; i++)
            {
                bool setBit = (aByte & mask) != 0;
                StegBit(bm, setBit, ref x, ref y, ref component);
                mask <<= 1;
            }
        }

        // Hide a single bit in the image.
        // The bit parameter should be true to set the bit, false to clear it.
        private static void StegBit(Bitmap bm, bool bit, ref int x, ref int y, ref RGB component)
        {
            Color color = bm.GetPixel(x, y);
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;
            byte a = color.A;
            if (component == RGB.R)
            {
                if (bit) r |= 0b00000001;
                else r &= 0b11111110;
                color = Color.FromArgb(a, r, g, b);
                bm.SetPixel(x, y, color);

                component = RGB.G;
            }
            else if (component == RGB.G)
            {
                if (bit) g |= 0b00000001;
                else g &= 0b11111110;
                color = Color.FromArgb(a, r, g, b);
                bm.SetPixel(x, y, color);

                component = RGB.B;
            }
            else
            {
                if (bit) b |= 0b00000001;
                else b &= 0b11111110;
                color = Color.FromArgb(a, r, g, b);
                bm.SetPixel(x, y, color);

                component = RGB.R;
                if (++x >= bm.Width)
                {
                    // Move to the next row.
                    x = 0;
                    y++;
                }
            }
        }

        #endregion Steg Methods

        #region Desteg Methods

        // Get a message from the image.
        public static string DestegMessage(this Bitmap bm)
        {
            // Get the message length.
            int x = 0, y = 0;
            RGB component = RGB.R;
            byte[] lengthBytes = DestegBytes(bm, sizeof(int), ref x, ref y, ref component);
            int messageLength = BitConverter.ToInt32(lengthBytes, 0);

            // Get the message.
            byte[] messageBytes = DestegBytes(bm, messageLength, ref x, ref y, ref component);
            string message = Encoding.Unicode.GetString(messageBytes);
            return message;
        }

        // Get an array of bytes from the image.
        private static byte[] DestegBytes(Bitmap bm, int length, ref int x, ref int y, ref RGB component)
        {
            byte[] result = new byte[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = DestegByte(bm, ref x, ref y, ref component);
            }
            return result;
        }

        // Get a byte from the image.
        private static byte DestegByte(Bitmap bm, ref int x, ref int y, ref RGB component)
        {
            byte mask = 0b00000001;
            byte result = 0;
            for (int i = 0; i < 8; i++)
            {
                if (DestegBit(bm, ref x, ref y, ref component))
                    result |= mask;
                else
                    result &= (byte)~mask;
                mask <<= 1;
            }
            return result;
        }

        // Get a single bit from the image. Return true if the bit is set.
        private static bool DestegBit(Bitmap bm, ref int x, ref int y, ref RGB component)
        {
            Color color = bm.GetPixel(x, y);
            bool result;
            if (component == RGB.R)
            {
                result = (color.R & 0b00000001) != 0;
                component = RGB.G;
            }
            else if (component == RGB.G)
            {
                result = (color.G & 0b00000001) != 0;
                component = RGB.B;
            }
            else
            {
                result = (color.B & 0b00000001) != 0;
                component = RGB.R;

                // Move to the next pixel.
                if (++x >= bm.Width)
                {
                    // Move to the next row.
                    x = 0;
                    y++;
                }
            }
            return result;
        }

        #endregion Desteg Methods
    }
}
