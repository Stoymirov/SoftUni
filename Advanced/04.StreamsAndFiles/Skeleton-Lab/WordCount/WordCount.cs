using System.Collections;
using System.Text.RegularExpressions;

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
         string[] words =  File.ReadAllText(wordsFilePath).Split();
         string textWords = File.ReadAllText(textFilePath);
         Dictionary<string, int > wordCount = new Dictionary<string, int>();

         string[] text = Regex.Replace(textWords, @"[^\w\s]", "").ToLower().Split(new []{' ','\n','\t','\r'},StringSplitOptions.RemoveEmptyEntries);
         foreach (var word in words)
         {
             int count = 0;
             foreach (var textWord in text)
             {
                 if (string.Equals(word,textWord,StringComparison.OrdinalIgnoreCase))
                 {
                     count++;
                 }
             }

             if (!wordCount.ContainsKey(word))
             {
                    wordCount.Add(word, count );
             }
             
         }

         using (StreamWriter writer = new StreamWriter(outputFilePath))
         {
             foreach (var i in wordCount.OrderByDescending(x=>x.Value))
             {
                 writer.WriteLine($"{i.Value} - {i.Key}");
             }
         }
        }
    }
}
