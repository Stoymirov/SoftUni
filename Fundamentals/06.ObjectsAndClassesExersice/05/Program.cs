using System.Data;

int countOfTeams = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();
for (int i = 0; i < countOfTeams; i++)
{
    string[] array = Console.ReadLine().Split("-");

    string creator = array[0];
    string teamName = array[1];
    Team newTeam = new Team(teamName, creator);

    Team sameTeamFound = teams.Find(x => x.Name == teamName);
    Team sameCreatorFound = teams.Find(x=>x.Creator == creator);
    if (sameTeamFound != null)
    {
        Console.WriteLine($"Team {teamName} was already created!");
        continue;
    }

    if (sameCreatorFound != null)
    {
        Console.WriteLine($"{creator} cannot create another team!");
        continue;
    }

    teams.Add(newTeam);
    Console.WriteLine($"Team {teamName} has been created by {creator}!");
}
string command = "";
while ((command = Console.ReadLine()) != "end of assignment")
{
    string[] array = command.Split("->");
    string user = array[0];
    string teamName = array[1];

    bool teamExists = teams.Any(x => x.Name == teamName);
    bool PlayerIsIn = teams.Any(x=>x.Members.Contains(user)) ||
                      teams.Any(x=>x.Creator == user);
    if (!teamExists)
    {
        Console.WriteLine($"Team {teamName} does not exist!");
        continue;
    }

    if (PlayerIsIn)
    {
        Console.WriteLine($"Member {user} cannot join team {teamName}!");
        continue;
    }

    teams.FirstOrDefault(t => t.Name == teamName).Members.Add(user);
}
List<Team> disdainedTeams = new List<Team>();
List<Team> teamLeft = new List<Team>();
teamLeft = teams.Where(t => t.Members.Count > 0).ToList();
disdainedTeams = teams.Where(t => t.Members.Count == 0).ToList();

teamLeft = teamLeft.OrderByDescending(t => t.Members.Count).ThenBy(t=>t.Name).ToList();
disdainedTeams = disdainedTeams.OrderBy(t => t.Name).ToList();

teamLeft.ForEach(t => Console.WriteLine(t));
Console.WriteLine("Teams to disband:");
foreach (Team team in disdainedTeams)
{
    Console.WriteLine(team.Name);
}






    
class Team
{
    public Team(string team, string creator)
    {
        Members = new List<string>();
        Name = team;
        Creator = creator;
    }
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public override string ToString()
    {
       
        return $"{Name} \n- {Creator} \n-- {string.Join("\n-- ", Members.OrderBy(Name=>Name))}";
    }
}