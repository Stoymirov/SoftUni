using System;

int n = int.Parse(Console.ReadLine());

int[] numberOfWords = new int[n];
for (int i = 0; i < n; i++)
{
    int charSum = 0;
    string word = Console.ReadLine();

    char[] chars = word.ToCharArray();


    for (int j = 0; j < chars.Length; j++)
    {
        if (chars[j] == 97 || chars[j] == 117 || chars[j] == 105 || chars[j] == 101 || chars[j] == 111 || chars[j] == 65 || chars[j] == 85 || chars[j] == 79 || chars[j] == 69 || chars[j] == 73)
        {

            charSum += (int)chars[j] * chars.Length;
        }
        else
        {
            charSum += (int)chars[j] / chars.Length;
        }
    }
    numberOfWords[i] = charSum;
}
Array.Sort(numberOfWords);
foreach (int number in numberOfWords)
{
    Console.WriteLine(number);
}


