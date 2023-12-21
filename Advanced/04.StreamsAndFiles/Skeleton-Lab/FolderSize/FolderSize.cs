namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            Console.WriteLine(GetFolderSize(folderPath));
            
        }

        public static long GetFolderSize(string path)
        {
            string[] filePaths = Directory.GetFiles(path);

            long size = 0;
            foreach (string filePath in filePaths)
            {
                FileInfo info = new FileInfo(filePath);
                size += info.Length;
                Console.WriteLine(filePath);
            }

            foreach (var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSize(dirPaths);
            }

            return size;
        }
    }
}
 