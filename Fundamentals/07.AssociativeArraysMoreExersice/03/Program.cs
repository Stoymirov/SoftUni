
using System.Text.RegularExpressions;

Dictionary<string, List<Position>> myDictionary = new Dictionary<string, List<Position>>();

string command = String.Empty;

while ((command = Console.ReadLine()) != "Season end")
{
    string[] array = Regex.Split(command, @" -> | vs ");

    if (array.Length == 3)
    {
        string player = array[0];
        string position = array[1];
        int skill = int.Parse(array[2]);

        var contains = myDictionary.ContainsKey(player);
        if (!contains)
        {
            myDictionary.Add(player, new List<Position>());
        }

        var existiongPosition = myDictionary[player].Find(x => x.Name == position);
        if (existiongPosition == null)
        {
            myDictionary[player].Add(new Position(position, skill));
        }
        else
        {
            if (existiongPosition.Skill < skill)
            {
                existiongPosition.Skill = skill;
            }
        }
    }
    else
    {
        string player1 = array[0];
        string player2 = array[1];
        if (myDictionary.ContainsKey(player2) && myDictionary.ContainsKey(player1))
        {
            var vaarr = myDictionary[player1].Any(x => myDictionary[player2].Any(y => x.Name == y.Name));

            if (vaarr)
            {
                int player1Score = myDictionary[player1].Sum(x => x.Skill);
                int player2Score = myDictionary[player2].Sum(x => x.Skill);

                if (player1Score > player2Score)
                {
                    myDictionary.Remove(player2);

                }
                else if (player2Score > player1Score)
                {
                    myDictionary.Remove(player1);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

foreach (var VARIABLE in myDictionary.OrderByDescending(x => x.Value.Sum(x => x.Skill)).ThenBy(x => x.Key))
{
    Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value.Sum(x => x.Skill)} skill");
    foreach (var VARIABLE2 in VARIABLE.Value.OrderByDescending(x => x.Skill).ThenBy(x => x.Name))
    {
        Console.WriteLine($"- {VARIABLE2.Name} <::> {VARIABLE2.Skill}");
    }
}





class Position
{
    public Position(string name, int skill)
    {
        Name = name;
        Skill = skill;
    }
    public string Name { get; set; }
    public int Skill { get; set; }
}