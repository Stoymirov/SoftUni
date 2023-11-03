
Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string group = Console.ReadLine();
    string word = Console.ReadLine();
    if (myDictionary.ContainsKey(group))
    {
        myDictionary[group].Add(word);

        ; /*= new List<string>();
        myDictionary[group].Add(word);*/

    }
    else
    {
        myDictionary.Add(group, new List<string>());
        myDictionary[group].Add(word);
    }
}

foreach (KeyValuePair<string, List<string>> kvp in myDictionary)
{
    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
}