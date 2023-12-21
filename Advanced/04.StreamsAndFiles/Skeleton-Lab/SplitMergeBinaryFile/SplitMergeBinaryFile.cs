using System.Collections.Generic;

namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream stream = new FileStream(sourceFilePath, FileMode.Create))
            {
                int parts = 2;
                long length = stream.Length / 2;
               
                    using (FileStream partStream = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[length];
                        stream.Read(buffer, 0, (int)length);
                        partStream.Write(buffer,0,buffer.Length);
                    }
                    using (FileStream partStream = new FileStream(partTwoFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[length];
                        stream.Read(buffer, 0, (int)length);
                        partStream.Write(buffer, 0, buffer.Length);
                    }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
        }
    }
}