using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DirectorySizePLINQ
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

        // Use LINQ to calculate the directory's size.
        public static long SizeLINQ(this DirectoryInfo dirinfo, bool includeSubdirs = false)
        {
            // Get the files within the directory.
            FileInfo[] fileinfos;
            if (includeSubdirs)
                fileinfos = dirinfo.GetFiles("*", SearchOption.AllDirectories);
            else
                fileinfos = dirinfo.GetFiles("*", SearchOption.TopDirectoryOnly);

            // Add the file sizes.
            var sizeQuery =
                from FileInfo fileinfo in fileinfos
                select fileinfo.Length;
            return sizeQuery.Sum();
        }

        // Use PLINQ to calculate the directory's size.
        public static long SizePLINQ(this DirectoryInfo dirinfo, bool includeSubdirs = false)
        {
            // Get the files within the directory.
            FileInfo[] fileinfos;
            if (includeSubdirs)
                fileinfos = dirinfo.GetFiles("*", SearchOption.AllDirectories);
            else
                fileinfos = dirinfo.GetFiles("*", SearchOption.TopDirectoryOnly);

            // Add the file sizes.
            var sizeQuery =
                from FileInfo fileinfo in fileinfos.AsParallel()
                select fileinfo.Length;
            return sizeQuery.Sum();
        }
    }
}