int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> wDictionary =
    new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{ 
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!wDictionary.ContainsKey(word))
    {
        List<string> newList = new List<string>();
        wDictionary.Add(word, newList);
    }
    List<string> currentList = wDictionary[word];
    currentList.Add(synonym);
}

foreach (var (word,synonym) in wDictionary)
{
    Console.WriteLine($"{word} - {string.Join(", ", synonym)}");
}