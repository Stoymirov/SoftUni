using System.Text.RegularExpressions;

namespace WordCount 
{ public class WordCount 
    { static void Main() 
        { string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt"; 
            CalculateWordCounts(wordPath, textPath, outputPath); }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                
            }

           

            string text = "";
            string pattern = @"[\p{P}]";
            string[] result = Regex.Split(text, pattern);
        }

    }

}