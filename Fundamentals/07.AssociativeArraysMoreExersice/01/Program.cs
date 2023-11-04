using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, Contest> dictionaryOfContests = new Dictionary<string, Contest>();
SortedDictionary<string, List<Contest>> peopleWithContests = new SortedDictionary<string, List<Contest>();

string command = String.Empty;

while ((command = Console.ReadLine()) != "end of contests")
{
    string[] array = command.Split(":").ToArray();
    string contestName = array[0];
    string contestPassword = array[1];

    Contest contest = new Contest(contestName, contestPassword);
    dictionaryOfContests.Add(contestName, contest);
}

string command2 = String.Empty;
while ((command2 = Console.ReadLine()) != "end of submissions")
{
    string[] array = command2.Split("=>").ToArray();
    string contestName = array[0];
    string contestPassword = array[1];
    string contestUsername = array[2];
    int contestPoints;

    if (int.TryParse(array[3], out contestPoints) && dictionaryOfContests.TryGetValue(contestName, out Contest contest))
    {
        if (contest.Password == contestPassword)
        {
            if (!peopleWithContests.ContainsKey(contestUsername))
            {
                peopleWithContests[contestUsername] = new List<Contest>();
            }

            int indexOfTheSamePErsonWithSameCourse = peopleWithContests[contestUsername]
                .FindIndex(x => x.Points < contestPoints && x.Name == contestName);

            if (indexOfTheSamePErsonWithSameCourse != -1)
            {
                peopleWithContests[contestUsername][indexOfTheSamePErsonWithSameCourse].Points = contestPoints;
            }
            else if (peopleWithContests[contestUsername].Any(x => x.Name == contestName))
            {
                contest.Points = contestPoints;
                peopleWithContests[contestUsername].Add(contest);
            }
        }
    }
}

var bestCandidate = peopleWithContests.MaxBy(p => p.Value.Sum(c => c.Points));
Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Sum(c => c.Points)} points.");
Console.WriteLine("Ranking:");
foreach (var kvp in peopleWithContests)
{
    Console.WriteLine(kvp.Key);
    foreach (var obj in kvp.Value.OrderByDescending(c => c.Points))
    {
        Console.WriteLine($"# {obj.Name} -> {obj.Points}");
    }
}

class Contest
{
    public Contest(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public string Name { get; set; }
    public string Password { get; set; }
    public int Points { get; set; }
}
