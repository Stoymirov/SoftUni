//create a dictionary which has a key that is the name of the contest and a value class which has the contensts
//if there is such contest (contains key) check if the password in the class is valid
//create a dictionary which has a key a person and then i list of classes of courses
//in the contents class keep[ the password, points for person and name of contest]

using System.Diagnostics.CodeAnalysis;

Dictionary<string, Contest> dictionaryOfContests =
    new Dictionary<string, Contest>();

SortedDictionary<string, List<Contest>> peopleWithContests =
    new SortedDictionary<string, List<Contest>>();

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
    int contestPoints = int.Parse(array[3]);

    if (dictionaryOfContests.TryGetValue(contestName, out var ofContest))
    {

        if (ofContest.Password == contestPassword)
        {
            if (!peopleWithContests.ContainsKey(contestUsername))
            {
                List<Contest> newList = new List<Contest>();
                peopleWithContests.Add(contestUsername, newList);
            }

            int indexOfTheSamePErsonWithSameCourse = peopleWithContests[contestUsername]
                .FindIndex(x => x.Points < contestPoints && x.Name == contestName);

            if (indexOfTheSamePErsonWithSameCourse != -1)
            {
                peopleWithContests[contestUsername][indexOfTheSamePErsonWithSameCourse].Points = contestPoints;
            }
            else if(!peopleWithContests[contestUsername].Exists(x=>x.Name==contestName))
            {
                Contest contest = new Contest(contestName, contestPassword);
                contest.Points = contestPoints;
                peopleWithContests[contestUsername].Add(contest);

            }
        }
    }
}

var bestCandidate = peopleWithContests.MaxBy(p => p.Value.Sum(c => c.Points));



Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value} points.");
Console.WriteLine("Ranking: ");
foreach (KeyValuePair<string,List<Contest>> kvp in peopleWithContests)
{
    Console.WriteLine(kvp.Key);
    foreach (var obj in kvp.Value.OrderByDescending(c=>c.Points))
    {
        Console.WriteLine("#  " + string.Join("# ",$"{obj.Name} -> {obj.Points}"));
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