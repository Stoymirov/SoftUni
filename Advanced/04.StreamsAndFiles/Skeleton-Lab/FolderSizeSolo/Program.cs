using System.Net.Security;

namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\ProgrammingProjects\SoftUniProjects\SoftUni\Advanced";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {

            long size = GetFolderSize(folderPath, 0);
            File.WriteAllText(outputFilePath,$"{size/1024/1024} MB");
        }

        public static long GetFolderSize(string path, int level)
        {
            Console.WriteLine($"{new string(' ',level*3)}{new DirectoryInfo(path).Name}");
            string[] filePaths = Directory.GetFiles(path);
            long size = 0;
            foreach (string file in filePaths)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
                Console.WriteLine($"{new string(' ',level*3)}{info.Name}");
            }

            foreach (var dirPath in Directory.GetDirectories(path))
            {
               size+= GetFolderSize(dirPath,level+1);
            }

            return size;
        }
       
    }
}