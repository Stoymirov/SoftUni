using System;

string[] input = Console.ReadLine().Split(' ');

string string1 = input[0];
string string2 = input[1];

int result = 0;

int maxLength = Math.Max(string1.Length, string2.Length);
for (int i = 0; i < maxLength; i++)
{
    string1.Length <= i ? result += int.Parse(string2[i]) : result += string1[i] * string2[i];
    string2.Length <= i ? result += int.Parse(string1[i]) : result += string1[i] * string2[i];
}

System.Console.WriteLine(result);
