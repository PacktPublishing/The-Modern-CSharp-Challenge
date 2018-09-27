using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Security.Cryptography;

namespace HashFiles
{
    public static class CryptoExtensions
    {
        // Return a file's MD5 hash.
        public static string CalculateMD5(string filename)
        {
            // Make an MD5 hashing object.
            using (MD5 md5 = MD5.Create())
            {
                // Open the file and pass the stream into the MD5 object.
                using (FileStream stream = File.OpenRead(filename))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash);
                }
            }
        }
    }
}
