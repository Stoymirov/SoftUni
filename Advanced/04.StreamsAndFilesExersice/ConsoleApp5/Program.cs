using System.Text;
using System.Text.RegularExpressions;

using System;
using System.Security.Cryptography.X509Certificates;

namespace CopyDirectory;
public class CopyDirectory
{
    static void Main()
    {
        string inputFilePath = @$"{Console.ReadLine()}";
        string outputFilePath = @$"{Console.ReadLine()}";
        

        CopyAllFiles(inputFilePath, outputFilePath);
    }

    private static void CopyAllFiles(string inputFilePath, string outputFilePath)
    {

        if (Directory.Exists(outputFilePath))
        {
            Directory.Delete(outputFilePath);
        }
        Directory.CreateDirectory(outputFilePath);
        string[] fileNames = Directory.GetFiles(inputFilePath);

        foreach (var file in fileNames)
        {
            string fileName = Path.GetFileName(file);
            string destination = Path.Combine(outputFilePath,fileName);
            File.Copy(file, destination);
        }  

    }

    
}