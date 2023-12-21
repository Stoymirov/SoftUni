Dictionary<string, string> contestInfo = new Dictionary<string, string>();
Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();

string command = "";

while ((command = Console.ReadLine()) != "end of contests")
{
    string[] array = command.Split(":");
    contestInfo.Add(array[0], array[1]);
}

while ((command = Console.ReadLine()) != "end of submissions")
{
    string[] array = command.Split("=>");
    string test = array[0];
    string pass = array[1];
    string name = array[2];
    int points = int.Parse(array[3]);
    if (contestInfo.ContainsKey(test))
    {
        if (contestInfo[test] == pass)
        {
            if (submissions.ContainsKey(name) && submissions[name].ContainsKey(test))
            {
                
                    if (submissions[name][test] < points)
                    {
                        submissions[name][test] = points;
                    }
                
            }
            else
            {
                if (!submissions.ContainsKey(name))
                submissions.Add(name,new Dictionary<string, int>());
                submissions[name].Add(test, points);
            }
        }
    }
}

var personMostP = submissions.OrderByDescending(x => x.Value.Sum(y=>y.Value)).FirstOrDefault();
Console.WriteLine($"Best candidate is {personMostP.Key} with total {personMostP.Value.Sum(y=>y.Value)} points.");
Console.WriteLine("Ranking:");
foreach (var candidate in submissions.OrderBy(x => x.Key))
{
    Console.WriteLine(candidate.Key);
    foreach (var contest in candidate.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}
