using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DirectorySize
{
    public static class IOExtensions
    {
        // Calculate the directory's size.
        public static long Size(this DirectoryInfo dirinfo, bool includeSubdirs = false)
        {
            // Get the files within the directory.
            FileInfo[] fileinfos;
            if (includeSubdirs)
                fileinfos = dirinfo.GetFiles("*", SearchOption.AllDirectories);
            else
                fileinfos = dirinfo.GetFiles("*", SearchOption.TopDirectoryOnly);

            // Add the file sizes.
            long size = 0;
            foreach (FileInfo fileinfo in fileinfos) size += fileinfo.Length;

            return size;
        }
    }
}
