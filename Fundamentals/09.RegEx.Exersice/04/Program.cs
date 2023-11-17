using System.Collections.Specialized;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
Regex regex = new Regex(@"[star]",RegexOptions.IgnoreCase);
Regex regex2 =
    new Regex(
        @"[^!,@\-:>]*\@(?<planetName>[A-Za-z]+)[^!,@\-:>]*:(?<planetPopulation>\d+)[^!,@\-:>]*!(?<atackName>[A|D])![^!,@\-:>]*\->(?<soldierCount>\d+)[^!,@\-:>]*");
List<string> planetsDecrypted = new List<string>();
Dictionary<string, List<Planet>> myDic = new Dictionary<string, List<Planet>>();
for (int i = 0; i < n; i++)//decrypting planets
{
    string encryptedMessage = Console.ReadLine();
    int count = regex.Matches(encryptedMessage).Count();
    string deCrypted = "";
    foreach (char VARIABLE in encryptedMessage)
    {
        deCrypted += (char)(VARIABLE - count);
    }
    planetsDecrypted.Add(deCrypted);
}



foreach (var VARIABLE in planetsDecrypted)//taking the information for each planet
{
    Match matches = regex2.Match(VARIABLE);
    if (matches.Success)
    {
        string planetName = matches.Groups["planetName"].Value;
        string planetPopulation = matches.Groups["planetPopulation"].Value;
        string atackName = matches.Groups["atackName"].Value;
        string soldierCount = matches.Groups["soldierCount"].Value;
        Planet currentPlanet = new Planet(planetName, planetPopulation, atackName, soldierCount);
        List<Planet> newPlanet = new List<Planet>();
        newPlanet.Add(currentPlanet);
        if (!myDic.ContainsKey("attacked") && atackName == "A")
        {
            myDic.Add("attacked", newPlanet);
        }
        else if (!myDic.ContainsKey("destroyed") && atackName == "D")

        {
            myDic.Add("destroyed", newPlanet);
        }
        else if (myDic.ContainsKey("attacked") && atackName == "A")
        {
            myDic["attacked"].Add(currentPlanet);
        }
        else if (myDic.ContainsKey("destroyed") && atackName == "D")
        {
            myDic["destroyed"].Add(currentPlanet);
        }
    }
}


if (myDic.ContainsKey("attacked"))
{
    Console.WriteLine($"Attacked planets: {myDic["attacked"].Count}");
    foreach (var planet in myDic["attacked"].OrderBy(x=>x.Name))
    {
        Console.WriteLine($"-> {planet.Name}");
    }
}
else Console.WriteLine("Attacked planets: 0");

if (myDic.ContainsKey("destroyed"))
{
    Console.WriteLine($"Destroyed planets: {myDic["destroyed"].Count}");
    foreach (var planet in myDic["destroyed"].OrderBy(x => x.Name))
    {
        Console.WriteLine($"-> {planet.Name}");
    }
}
else Console.WriteLine(("destroyed planets: 0"));

class Planet
{
    public Planet(string planetName, string planetPopulation, string atackName, string soldierCount)
    {
        Name = planetName;
        PlanetPopulation = planetPopulation;
        AtackName = atackName;
        SoldierCount = soldierCount;
    }

    public string Name { get; set; }
    public string PlanetPopulation { get; set; }
    public string AtackName { get; set; }
    public string SoldierCount { get; set; }
}