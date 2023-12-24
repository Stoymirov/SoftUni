using System.Text;
using System.Text.RegularExpressions;

using System;
using System.Security.Cryptography.X509Certificates;

namespace CopyBinaryFiles;
public class CopyBinaryFiles
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\copyMe.png";
        string outputFilePath = @"..\..\..\copyMe-copy.png";

        CopyFile(inputFilePath, outputFilePath);
    }

    public static void CopyFile(string inputFilePath, string outputFilePath)
    {
       using FileStream reader = new(inputFilePath,FileMode.Open);
       using FileStream writer = new(outputFilePath, FileMode.Create);

        byte[] buffer = new byte[512];
        int size = 0;

        while ((size = reader.Read(buffer, 0, buffer.Length)) != 0)
        {
            writer.Write(buffer, 0, size);
        }
;        
        
        
        
        
        
        
        
        //using (FileStream stream = new FileStream(inputFilePath, FileMode.Open))
        //{
        //    byte[] buffer = new byte[stream.Length];
        //    stream.Read(buffer,0,buffer.Length);
        //    using (FileStream stream2 = new FileStream(outputFilePath, FileMode.OpenOrCreate))
        //    {
        //        stream2.Write(buffer,0,buffer.Length);
        //    }
        //}
    }
}