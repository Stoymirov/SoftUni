string input = Console.ReadLine();
SortedDictionary<char, int> letters =  new SortedDictionary<char, int>();

foreach (var character in input)
{
    if (!letters.ContainsKey(character))
    {
        letters.Add(character, 0);
    }
    letters[character]++;
}

foreach (var letter in letters)
{
    Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
}