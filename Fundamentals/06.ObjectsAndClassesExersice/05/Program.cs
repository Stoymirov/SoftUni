using System.Data;

int countOfTeams = int.Parse(Console.ReadLine());
List<Team> teams = new List<Team>();
for (int i = 0; i < countOfTeams; i++)
{
    string[] array = Console.ReadLine().Split("-");

    string creator = array[0];
    string teamName = array[1];

    
    Team team = new Team();
    team.Name = teamName;
    team.Creator = creator;
    teams.Add(team);
    
    Console.WriteLine($"Team {teamName} has been created by {creator}!");
}
string command = "";
while ((command = Console.ReadLine()) != "end of assignment") ;
{
    string[] array = Console.ReadLine().Split("->");
    string user = array[0];
    string teamName = array[1];

}














class Team
{
  //public  Team(string team, string creator)
  //  {
  //      Members = new List<string>();
  //      Name = team;
  //      Creator = creator;
  //  }
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}