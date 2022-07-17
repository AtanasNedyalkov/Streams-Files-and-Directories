namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"C:\Users\Admin\Downloads\Skeleton-Exercise\Skeleton\ZipAndExtract\copyMe.png";
            string zipArchiveFile = @"C:\Users\Admin\Downloads\Skeleton-Exercise\Skeleton\ZipAndExtract\archive.zip";
            string extractedFile = @"C:\Users\Admin\Downloads\Skeleton-Exercise\Skeleton\ZipAndExtract\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                string fileName = Path.GetFileName(inputFilePath);
                archive.CreateEntryFromFile(inputFilePath, fileName);
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            var archive = ZipFile.OpenRead(outputFilePath);
            var fileForExtraction = archive.GetEntry(fileName);

            fileForExtraction.ExtractToFile(outputFilePath);
        }
    }
}
