using System.Text;

string[] arrayOfStrings = Console.ReadLine().Split();

StringBuilder sb = new StringBuilder();
foreach (string str in arrayOfStrings)
{
    int countLetters = str.Length;
    Console.WriteLine();
    for (int i = 0; i < countLetters; i++)
    {
        sb.Append(str);
    }
}
Console.WriteLine(sb);