using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FindDuplicateFiles
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
            List<FileInfo> fileList = new List<FileInfo>();
            foreach (string pattern in patterns)
            {
                foreach (FileInfo fileinfo in dirinfo.GetFiles(pattern, option))
                {
                    if (!fileList.Contains(fileinfo)) fileList.Add(fileinfo);
                }
            }

            // Sort and return.
            FileInfo[] fileArray = fileList.ToArray();
            string[] filenames = new string[fileArray.Length];
            for (int i = 0; i < fileArray.Length; i++)
                filenames[i] = fileArray[i].FullName;
            Array.Sort(filenames, fileArray);
            return fileArray;
        }

        // Return lists of files with the same sizes.
        // If a file is the only one of its size, do not include it.
        public static List<List<FileInfo>> GetSameSizedFiles(this DirectoryInfo dirinfo)
        {
            // Get the directory's files.
            FileInfo[] fileinfos = dirinfo.GetFiles();

            // Get the file sizes.
            long[] filesizes = new long[fileinfos.Length];
            for (int i = 0; i < fileinfos.Length; i++) filesizes[i] = fileinfos[i].Length;

            // Sort by file size.
            Array.Sort(filesizes, fileinfos);

            // Find groups of files with the same sizes.
            List<List<FileInfo>> groups = new List<List<FileInfo>>();
            int num = 1;
            while (num < fileinfos.Length)
            {
                if (fileinfos[num].Length != fileinfos[num - 1].Length)
                    // No match. Move on to the next size.
                    num++;
                else
                {
                    // We have a match. Make a list of files with this size.
                    List<FileInfo> files = new List<FileInfo>();
                    groups.Add(files);
                    files.Add(fileinfos[num - 1]);
                    long length = fileinfos[num - 1].Length;
                    while ((num < fileinfos.Length) && (fileinfos[num].Length == length))
                    {
                        files.Add(fileinfos[num++]);
                    }
                }
            }
            return groups;
        }

        // Return lists of identical files.
        public static List<List<FileInfo>> GetIdenticalFiles(this DirectoryInfo dirinfo)
        {
            // Get lists of files that have the same sizes.
            List<List<FileInfo>> sameSizedFiles = dirinfo.GetSameSizedFiles();

            // Make a list to hold identical file lists.
            List<List<FileInfo>> results = new List<List<FileInfo>>();
            if (sameSizedFiles.Count == 0) return results;

            foreach (List<FileInfo> sizeGroup in sameSizedFiles)
            {
                while (sizeGroup.Count > 1)
                {
                    // Make a list for the first file.
                    List<FileInfo> identicalGroup = new List<FileInfo>();
                    FileInfo fileinfo1 = sizeGroup[0];
                    identicalGroup.Add(fileinfo1);
                    identicalGroup.RemoveAt(0);

                    // See if any other files should be in this group.
                    for (int i = sizeGroup.Count - 1; i >= 0; i--)
                    {
                        if (FilesAreIdentical(fileinfo1, sizeGroup[i]))
                        {
                            // The files are identical. Add the new one to the identical list.
                            identicalGroup.Add(sizeGroup[i]);
                            sizeGroup.RemoveAt(i);
                        }
                    }

                    // See if this identical group is empty.
                    if (identicalGroup.Count > 1) results.Add(identicalGroup);
                }
            }

            // Return the identical groups.
            return results;
        }

        // Return true if the files are identical.
        public static bool FilesAreIdentical(FileInfo fileinfo1, FileInfo fileinfo2)
        {
            byte[] bytes1 = File.ReadAllBytes(fileinfo1.FullName);
            byte[] bytes2 = File.ReadAllBytes(fileinfo2.FullName);
            if (bytes1.Length != bytes2.Length) return false;
            for (int i = 0; i < bytes1.Length; i++)
                if (bytes1[i] != bytes2[i]) return false;
            return true;
        }
    }
}
