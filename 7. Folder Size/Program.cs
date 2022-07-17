using System.IO;
using System;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            decimal folderSize = GetFolderSize(@"C:\Program Files\7-Zip");
            Console.WriteLine(folderSize);
            Console.WriteLine($"{folderSize*(1024*1024):f2}Mb");

        }
        static decimal GetFolderSize(string folderPath)
        {
            decimal folderSize = 0;
            var dirInfo = new DirectoryInfo(folderPath);
            foreach (var f in dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                folderSize = folderSize + f.Length;
            }
            return folderSize;

        }
    }
}
