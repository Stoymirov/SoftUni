
    using System.IO;

    namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line = "";
                    int count = 0;
                    while (line != null) 
                    {
                        line = reader.ReadLine();
                        if (count % 2 != 0)
                        {
                          writer.WriteLine(line);

                        }

                        count++;
                    }
                }
            }






        }
    }
}
            //using (StreamReader reader = new StreamReader(inputFilePath))
            //{
            //    using (StreamWriter writer = new StreamWriter(outputFilePath))
            //    {
            //        string line = "";
            //        int row = 0;
            //        while (line != null)
            //        {
            //            line = reader.ReadLine();
            //            if (row % 2 == 1)
            //            {
            //                writer.WriteLine(line);
            //            }

            //            row++;
            //        }
            //    }
            //}