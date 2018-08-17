using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FindFilesLINQ
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

        // Find files that match any of the indicated patterns.
        // Do not include duplicates and return the files sorted.
        public static FileInfo[] GetFiles(this DirectoryInfo dirinfo,
            IEnumerable<string> patterns,
            SearchOption option = SearchOption.TopDirectoryOnly)
        {
            // Find files matching the patterns.
            Dictionary<string, FileInfo> fileDict = new Dictionary<string, FileInfo>();
            foreach (string pattern in patterns)
            {
                foreach (FileInfo fileinfo in dirinfo.GetFiles(pattern, option))
                {
                    if (!fileDict.ContainsKey(fileinfo.FullName))
                        fileDict.Add(fileinfo.FullName, fileinfo);
                }
            }

            // Sort and return.
            FileInfo[] fileinfos = fileDict.Values.ToArray();
            string[] filenames = fileDict.Keys.ToArray();
            Array.Sort(filenames, fileinfos);
            return fileinfos;
        }

        // Find files that match any of the indicated patterns and that
        // contain the target string.
        // Do not include duplicates and return the files sorted.
        public static FileInfo[] FindFiles(this DirectoryInfo dirinfo,
            IEnumerable<string> patterns, string target = "",
            SearchOption option = SearchOption.TopDirectoryOnly)
        {
            // Find files matching the patterns.
            FileInfo[] fileinfos = dirinfo.GetFiles(patterns, SearchOption.AllDirectories);

            // See if we should examine the files' contents.
            if ((target != null) && (target.Length > 0))
            {
                // See which files contain the required contents.
                List<FileInfo> newFiles = new List<FileInfo>();
                foreach (FileInfo fileinfo in fileinfos)
                {
                    string text = File.ReadAllText(fileinfo.FullName);
                    if (text.Contains(target)) newFiles.Add(fileinfo);
                }
                fileinfos = newFiles.ToArray();
            }

            return fileinfos;
        }

        // Find files that match any of the indicated patterns and that
        // contain the target string.
        // Do not include duplicates and return the files sorted.
        public static FileInfo[] FindFilesLINQ(this DirectoryInfo dirinfo,
            IEnumerable<string> patterns, string target = "",
            SearchOption option = SearchOption.TopDirectoryOnly)
        {
            // Find files that match the patterns.
            var fileQuery =
                from string pattern in patterns
                from FileInfo fileinfo in dirinfo.GetFiles(pattern, option)
                group fileinfo by fileinfo.FullName
                into namegroup
                select namegroup.First();
    
            // If target isn't blank, select files that contain it.
            if ((target != null) && (target.Length > 0))
                fileQuery =
                    from FileInfo fileinfo in fileQuery
                    where File.ReadAllText(fileinfo.FullName).Contains(target)
                    select fileinfo;

            // Take distinct values, sort, and return as an array.
            return fileQuery.OrderBy(x => x.Name).ToArray();
        }
    }
}
