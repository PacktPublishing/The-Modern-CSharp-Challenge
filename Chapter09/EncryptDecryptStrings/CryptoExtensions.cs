using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;

namespace EncryptDecryptStrings
{
    public static class CryptoExtensions
    {

        #region Bytes/Hex Conversion

        // Convert a byte[] into hexadecimal values.
        public static string BytesToHex(this byte[] bytes)
        {
            return BitConverter.ToString(bytes, 0);
        }

        // Convert two-digit hexadecimal values into a byte[].
        public static byte[] HexToBytes(this string hexString)
        {
            // Separate the bytes.
            char separator = hexString[2];
            string[] hexPairs = hexString.Split(separator);

            // Allocate the array.
            int numBytes = hexPairs.Length;
            byte[] bytes = new byte[numBytes];

            // Parse the pairs.
            for (int i = 0; i < numBytes; i++)
                bytes[i] = Convert.ToByte(hexPairs[i], 16);

            return bytes;
        }

        #endregion Bytes/Hex Conversion

        #region Setup

        // Prepare a cryptographic transformation for this password and SymmetricAlgorithm.
        private static ICryptoTransform MakeCryptoTransform(
            string password, bool doEncryption, SymmetricAlgorithm cryptoProvider)
        {
            // Find a valid key size for this provider.
            int numKeyBits = FindKeySize(cryptoProvider);
            Console.WriteLine($"Key size: {numKeyBits} bits");

            // Get the block size for this provider.
            int blockSizeBits = cryptoProvider.BlockSize;

            // Generate the key and IV.
            byte[] key = null;
            byte[] iv = null;
            byte[] salt = { 0x03, 0x07, 0x11, 0x22, 0xAB, 0xCD, 0x1F, 0xF1, 0xF1, 0x00, 0xA4, 0x6B, 0xC4, 0x99 };
            MakeKeyAndIV(password, salt, numKeyBits, blockSizeBits, out key, out iv);

            // Make the AES encryptor or decryptor.
            ICryptoTransform cryptoTransform;
            if (doEncryption)
                cryptoTransform = cryptoProvider.CreateEncryptor(key, iv);
            else
                cryptoTransform = cryptoProvider.CreateDecryptor(key, iv);

            return cryptoTransform;
        }

        // Use a password to make a key and IV.
        private static void MakeKeyAndIV(string password, byte[] salt,
            int keySizeBits, int blockSizeBits, out byte[] key, out byte[] iv)
        {
            Rfc2898DeriveBytes deriveBytes =
                new Rfc2898DeriveBytes(password, salt, 1000);
            key = deriveBytes.GetBytes(keySizeBits / 8);
            iv = deriveBytes.GetBytes(blockSizeBits / 8);
        }

        // Find a valid key size for this algorithm.
        private static int FindKeySize(SymmetricAlgorithm algorithm)
        {
            for (int i = 1024; i > 1; i--)
            {
                if (algorithm.ValidKeySize(i)) return i;
            }
            throw new InvalidOperationException(
                $"Cannot find a valid key size for {algorithm.GetType().Name}.");
        }

        #endregion Setup

        #region Encrypt and Decrypt Strings

        // Encrypt or decrypt a byte[].
        private static byte[] EncryptDecryptBytes(string password, byte[] inputBytes, bool doEncryption)
        {
            try
            {
                // Make the encryptor or decryptor.
                ICryptoTransform cryptoTransform = MakeCryptoTransform(password,
                doEncryption, new AesCryptoServiceProvider());

                // Make the output stream.
                using (MemoryStream outputStream = new MemoryStream())
                {
                    // Attach a CryptoStream.
                    using (CryptoStream cryptoStream = new CryptoStream(
                        outputStream, cryptoTransform, CryptoStreamMode.Write))
                    {
                        // Write the bytes into the CryptoStream.
                        cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        return outputStream.ToArray();
                    }
                }
            }
            catch (CryptographicException ex)
            {
                // The password is incorrect.
                throw new CryptographicException("Invalid password.", ex);
            }
            catch
            {
                // Re-throw.
                throw;
            }
        }

        // Encrypt a string into a byte[].
        public static byte[] Encrypt(this string plaintext, string password)
        {
            byte[] plainbytes = Encoding.Unicode.GetBytes(plaintext);
            return EncryptDecryptBytes(password, plainbytes, true);
        }

        // Decrypt a string from a byte[].
        public static string Decrypt(this byte[] cipherbytes, string password)
        {
            byte[] plainbytes = EncryptDecryptBytes(password, cipherbytes, false);
            return Encoding.Unicode.GetString(plainbytes);
        }

        #endregion Encrypt and Decrypt Strings

    }
}
