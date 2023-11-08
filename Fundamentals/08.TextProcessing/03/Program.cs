string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (var banned in bannedWords)
{
    text = text.Replace(banned, new string('*', banned.Length));
}

Console.WriteLine(text);