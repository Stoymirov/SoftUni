﻿using System.Text;
using System.Text.RegularExpressions;

using System;
using System.Security.Cryptography.X509Certificates;

namespace LineNumbers;
public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        StringBuilder sb = new StringBuilder();
        string[] lines = File.ReadAllLines(inputFilePath);
        for (int i = 0; i < lines.Length; i++)
        {
            int lettersCount = lines[i].Count(char.IsLetter);
            int symbolsCount = lines[i].Count(char.IsPunctuation);
            sb.AppendLine($"Line {i + 1}: {lines[i]} ({lettersCount})({symbolsCount})");
        }
        File.WriteAllText(outputFilePath,sb.ToString());
    }
}


