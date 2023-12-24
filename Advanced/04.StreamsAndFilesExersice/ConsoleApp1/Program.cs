using System.Text;
using System.Text.RegularExpressions;

namespace EvenLines;
using System;
public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder sb = new StringBuilder();
        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            int count = 0;

            string line = string.Empty;

            while ((line = reader.ReadLine())!=null)
            {
                if (count % 2 == 0)
                {
                    string replacedSymbols = ReplaceSymbols(line);
                    string reversedWords = ReverseSymbols(replacedSymbols);
                    sb.Append(reversedWords);
                }
                count++;
            }
        }

        return sb.ToString();
    }


    private static string ReplaceSymbols(string line)
    {
        StringBuilder sb = new(line);
        char[] symbolsToReplace = {'-', ',', '.', '!', '?' };
        foreach (var s in symbolsToReplace)
        {
            sb.Replace(s, '@');
        }
        return sb.ToString();
    }
    private static string ReverseSymbols(string replacedSymbols)
    {
        string[] reversed = replacedSymbols
            .Split()
            .Reverse()
            .ToArray();
        return string.Join(" ", reversed);
    }
}

