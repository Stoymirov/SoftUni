namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int counter = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"{counter++}. {line}");
                        line = reader.ReadLine();

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
            //        int n = 1;
            //        while (true)
            //        {
            //            line = reader.ReadLine();
            //            if (line == null)
            //                return;
            //            writer.WriteLine($"{n++}. {line}");
                        
            //        }
            //    }
            //}