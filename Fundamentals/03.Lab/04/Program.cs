string[] strings = Console.ReadLine().Split().ToArray();

for (int i = 0; i < strings.Length/2; i++)
{
    string firstCharacter = strings[i];
    string secondCharacter = strings[strings.Length - 1 - i];
    strings[i] = secondCharacter;
    strings[strings.Length - 1 - i] = firstCharacter;
}
Console.WriteLine(string.Join(" ", strings));

