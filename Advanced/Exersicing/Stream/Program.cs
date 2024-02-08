using System.ComponentModel.DataAnnotations;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\textoutput.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)

        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int n = 1;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (n == 1)
                        {
                            n++;
                            continue;
                        }

                        n = 1;
                        writer.WriteLine(line);
                    }
                }
            }

          
            
            
        }
    }
}