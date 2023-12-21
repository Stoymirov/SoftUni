Dictionary<string, Dictionary<string, HashSet<string>>> statistics = new Dictionary<string, Dictionary<string, HashSet<string>>>();
string command = "";

while ((command = Console.ReadLine()) != "Statistics")
{
    string[] array = command.Split(' ');
    if (command.Contains("joined"))
    {
        string name = array[0];
        if (!statistics.ContainsKey(name))
        {
            statistics.Add(name, new Dictionary<string, HashSet<string>>());
            statistics[name].Add("followers", new HashSet<string>());
            statistics[name].Add("following", new HashSet<string>());
        }
    }
    else
    {
        string follower = array[0];
        string followed = array[2];
        if (statistics.ContainsKey(followed)
            && statistics.ContainsKey(follower)
            && followed != follower
            && !statistics[follower]["following"].Contains(followed))
        {
            statistics[follower]["following"].Add(followed);
            statistics[followed]["followers"].Add(follower);
        }
    }
}

Console.WriteLine($"The V-Logger has a total of {statistics.Count} vloggers in its logs.");
int n = 1;
foreach (var vlogger in statistics.OrderByDescending(x => x.Value["followers"].Count)
             .ThenBy(v => v.Value["following"].Count))
{
    Console.WriteLine(
        $"{n}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
    if (n == 1)
    {
        foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
        {
            Console.WriteLine($"*  {follower}");
        }
    }

    n++;
}
