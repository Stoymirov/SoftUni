using System.Text;
using System.Text.RegularExpressions;

List<string> participantsName = Console.ReadLine().Split(", ").ToList();
List<Participant> participants = new List<Participant>();
foreach (string name in participantsName)
{
    Participant participant = new Participant(name);
    participants.Add(participant);
}
string command;
while ((command = Console.ReadLine()) != "end of race")
{
    StringBuilder nameBuilder = new StringBuilder();
    string lettersPattern = @"[A-Za-z]";
    foreach (Match m in Regex.Matches(command, lettersPattern))
    {
        nameBuilder.Append(m.Value);
    }
    string participantName = nameBuilder.ToString();

    uint distance = 0;
    string digitsPattern = @"\d";
    foreach (Match m in Regex.Matches(command, digitsPattern))
    {
        distance += uint.Parse(m.Value);
    }
    Participant existParticipant = participants.FirstOrDefault(p => p.Name == participantName);
    if (existParticipant != null)
    {
        existParticipant.Distance += distance;
    }
}

List<Participant> orderedParticipants = participants
    .OrderByDescending(m => m.Distance)
    .Take(3)
    .ToList();

Console.WriteLine($"1st place: {orderedParticipants[0].Name}");
Console.WriteLine($"2nd place: {orderedParticipants[1].Name}");
Console.WriteLine($"3rd place: {orderedParticipants[2].Name}");
public class Participant
{
    public Participant(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public uint Distance { get; set; }
}
/*
George, Peter, Bill, Tom
G4e@55or%6g6!68e!!@
R1@!3a$y4456@
B5@i@#123ll
G@e54o$r6ge#
7P%et^#e5346r
T$o553m&6
end of race
*/