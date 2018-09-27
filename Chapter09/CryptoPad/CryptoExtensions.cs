using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;

namespace CryptoPad
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
            // Specify the padding.
            cryptoProvider.Padding = PaddingMode.Zeros;

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
            Rfc2898DeriveBytes derive_bytes =
                new Rfc2898DeriveBytes(password, salt, 1000);
            key = derive_bytes.GetBytes(keySizeBits / 8);
            iv = derive_bytes.GetBytes(blockSizeBits / 8);
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
            UnicodeEncoding encoder = new UnicodeEncoding();
            byte[] plainbytes = encoder.GetBytes(plaintext);
            return EncryptDecryptBytes(password, plainbytes, true);
        }

        // Decrypt a string from a byte[].
        public static string Decrypt(this byte[] cipherbytes, string password)
        {
            byte[] plainbytes = EncryptDecryptBytes(password, cipherbytes, false);
            UnicodeEncoding encoder = new UnicodeEncoding();
            return encoder.GetString(plainbytes);
        }

        #endregion Encrypt and Decrypt Strings

        #region Encrypt and Decrypt Files

        // Encrypt or decrypt a file into another file.
        private static void CryptFile(string password, string inputFilename, string outputFilename, bool doEncryption)
        {
            try
            {
                // Make the encryptor or decryptor.
                ICryptoTransform cryptoTransform = MakeCryptoTransform(password,
                    doEncryption, new AesCryptoServiceProvider());

                // Make streams for the input and output files.
                using (FileStream inputStream = new FileStream(inputFilename, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream outputStream = new FileStream(outputFilename, FileMode.Create, FileAccess.Write))
                    {
                        // Attach a CryptoStream.
                        using (CryptoStream cryptoStream = new CryptoStream(
                            outputStream, cryptoTransform, CryptoStreamMode.Write))
                        {
                            // Write in blocks because a file stream may be too long to fit
                            // in an int and cryptoStream.Write needs an int number of bytes.
                            const int readingBlockSize = 16 * 1024;
                            byte[] buffer = new byte[readingBlockSize];
                            while (true)
                            {
                                // Read a block of bytes.
                                int numBytesRead = inputStream.Read(buffer, 0, readingBlockSize);
                                if (numBytesRead == 0) break;

                                // Write the bytes into the CryptoStream.
                                cryptoStream.Write(buffer, 0, numBytesRead);
                            }
                            cryptoStream.FlushFinalBlock();
                        }
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

        // Encrypt a file into another file.
        public static void EncryptFile(string password, string plainFilename, string cipherFilename)
        {
            CryptFile(password, plainFilename, cipherFilename, true);
        }

        // Decrypt a file into another file.
        public static void DecryptFile(string password, string cipherFilename, string plainFilename)
        {
            CryptFile(password, cipherFilename, plainFilename, false);
        }

        #endregion Encrypt and Decrypt Files

        #region Encrypt and Decrypt Files To and From Strings

        // Encrypt a string and save the results in a file.
        public static void EncryptIntoFile(this string plaintext, string password, string cipherFilename)
        {
            try
            {
                // Make the encryptor.
                ICryptoTransform cryptoTransform = MakeCryptoTransform(password,
                    true, new AesCryptoServiceProvider());

                // Make streams for the input text and output file.
                byte[] plainbytes = Encoding.Unicode.GetBytes(plaintext);
                using (MemoryStream inputStream = new MemoryStream(plainbytes))
                {
                    using (FileStream outputStream = new FileStream(cipherFilename, FileMode.Create, FileAccess.Write))
                    {
                        // Attach a CryptoStream.
                        using (CryptoStream cryptoStream = new CryptoStream(
                            outputStream, cryptoTransform, CryptoStreamMode.Write))
                        {
                            // Read and write in blocks.
                            const int readingBlockSize = 16 * 1024;
                            byte[] buffer = new byte[readingBlockSize];
                            while (true)
                            {
                                // Read a block of bytes.
                                int numBytesRead = inputStream.Read(buffer, 0, readingBlockSize);
                                if (numBytesRead == 0) break;

                                // Write the bytes into the CryptoStream.
                                cryptoStream.Write(buffer, 0, numBytesRead);
                            }
                            cryptoStream.FlushFinalBlock();
                        }
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

        // Decrypt a file and return the result in a string.
        public static string DecryptFromFile(string password, string cipherFilename)
        {
            try
            {
                // Make the decryptor.
                ICryptoTransform cryptoTransform = MakeCryptoTransform(password,
                    false, new AesCryptoServiceProvider());

                // Make streams for the input file and output MemoryStream.
                using (FileStream inputStream = new FileStream(cipherFilename, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        // Attach a CryptoStream.
                        using (CryptoStream cryptoStream = new CryptoStream(
                            outputStream, cryptoTransform, CryptoStreamMode.Write))
                        {
                            // Read and write in blocks.
                            const int readingBlockSize = 16 * 1024;
                            byte[] buffer = new byte[readingBlockSize];
                            while (true)
                            {
                                // Read a block of bytes.
                                int numBytesRead = inputStream.Read(buffer, 0, readingBlockSize);
                                if (numBytesRead == 0) break;

                                // Write the bytes into the CryptoStream.
                                cryptoStream.Write(buffer, 0, numBytesRead);
                            }
                            cryptoStream.FlushFinalBlock();

                            // Return the string.
                            byte[] plainbytes = outputStream.ToArray();
                            string plaintext = Encoding.Unicode.GetString(plainbytes);
                            return plaintext;
                        }
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

        #endregion Encrypt and Decrypt Files To and From Strings

    }
}
