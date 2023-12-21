using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader firstReader = new StreamReader(firstInputFilePath))
            using (StreamReader secondReader = new StreamReader(secondInputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string lineFromFirstFile = firstReader.ReadLine();
                string lineFromSecondFile = secondReader.ReadLine();

                while ((lineFromFirstFile != null || lineFromSecondFile != null))
                {
                    if (lineFromFirstFile != null)
                    {
                        writer.WriteLine(lineFromFirstFile);
                    }

                    if (lineFromSecondFile != null)
                    {
                        writer.WriteLine(lineFromSecondFile);
                    }
                    lineFromFirstFile = firstReader.ReadLine();
                    lineFromSecondFile = secondReader.ReadLine();
                }
                while ((lineFromFirstFile = firstReader.ReadLine()) != null)
                {
                    writer.WriteLine(lineFromFirstFile);
                }

                while ((lineFromSecondFile = secondReader.ReadLine()) != null)
                {
                    writer.WriteLine(lineFromSecondFile);
                }
            }
        }
    }
}