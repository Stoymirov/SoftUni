using System.Text;
using System.Text.RegularExpressions;

using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace ArchiveZip;
public class AzchiveZip
{
    static void Main()
    {
        string inputFilePath = @$"../../../copyMe.png";
        string zipArchiveFile = @$"../../../archive.zip";
        string extractedFile = @$"../../../extracted.png";
        ZipFileToArchive(inputFilePath, zipArchiveFile);


        var fileNameOnly = Path.GetFileName(inputFilePath);
        ExtractFileFromArchive(zipArchiveFile, fileNameOnly,extractedFile);
    }

    private static void ExtractFileFromArchive(string zipArchiveFile, string fileNameOnly, string extractedFile)
    {
      using ZipArchive archive = ZipFile.OpenRead(zipArchiveFile);
     ZipArchiveEntry archiveEntry = archive.GetEntry(fileNameOnly);
     archiveEntry.ExtractToFile(extractedFile);
    }

    private static void ZipFileToArchive(string inputFilePath, string zipArchiveFile)
    {
        using ZipArchive archive = ZipFile.Open(zipArchiveFile, ZipArchiveMode.Create);
        string fileName = Path.GetFileName(inputFilePath);
        archive.CreateEntryFromFile(inputFilePath, fileName);
    }

    


}