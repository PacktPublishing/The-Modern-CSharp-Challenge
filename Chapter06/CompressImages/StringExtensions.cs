using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace CompressImages
{
    public static class StringExtensions
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern Int32 StrFormatByteSize(long fileSize,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer, int bufferSize);

        // Use the StrFormatByteSize API function to convert a number of bytes into a file size.
        public static string ToFileSize(this long fileSize)
        {
            StringBuilder sb = new StringBuilder(20);
            StrFormatByteSize(fileSize, sb, 20);
            return sb.ToString();
        }
    }
}
