using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

Dictionary<string, int> peopleWithPoints = new Dictionary<string, int>();

Regex regex = new Regex(@"[A-Z]|[a-z]|\d");

string[] array = Console.ReadLine().Split(", ").ToArray();

foreach (string s in array)
{
    peopleWithPoints.Add(s, 0);
}
string command = "";
while ((command = Console.ReadLine()) != "end of race")
{
    string name = "";
    int racerPoints = 0;
    MatchCollection matches = regex.Matches(command);
    foreach (Match match in matches)
    {
        int number;
        if (int.TryParse(match.Value, out number))
        {
            racerPoints += number;
        }
        else
        {
            name += match.Value;
        }
    }

    if (peopleWithPoints.ContainsKey(name))
    {
        peopleWithPoints[name] += racerPoints;
    }


}

int counter = 1;
peopleWithPoints = peopleWithPoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
foreach (var VARIABLE in peopleWithPoints.Take(3))
{
    string place = counter == 1 ? "1st" : counter == 2 ? "2nd" : "3rd";
    Console.WriteLine($"{place} place: {VARIABLE.Key}");
    counter++;
}
