using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Regex regex = new Regex(@"[star]", RegexOptions.IgnoreCase);
        Regex planetInfoRegex = new Regex(@"@(?<planetName>[A-Za-z]+)[^@!\-:>]*:(?<planetPopulation>\d+)[^@!\-:>]*!(?<attackName>[AD])![^@!\-:>]*->(?<soldierCount>\d+)[^@!\-:>]*");

        List<string> planetsDecrypted = new List<string>();
        Dictionary<string, List<Planet>> myDic = new Dictionary<string, List<Planet>>();

        for (int i = 0; i < n; i++)
        {
            string encryptedMessage = Console.ReadLine();

            int count = regex.Matches(encryptedMessage).Count;

            string decryptedMessage = DecryptMessage(encryptedMessage, count);
            planetsDecrypted.Add(decryptedMessage);

            Match match = planetInfoRegex.Match(decryptedMessage);

            if (match.Success)
            {
                string planetName = match.Groups["planetName"].Value;
                string planetPopulation = match.Groups["planetPopulation"].Value;
                string attackName = match.Groups["attackName"].Value;
                string soldierCount = match.Groups["soldierCount"].Value;

                Planet currentPlanet = new Planet(planetName, planetPopulation, attackName, soldierCount);

                if (!myDic.ContainsKey("attacked") && attackName == "A")
                {
                    myDic.Add("attacked", new List<Planet> { currentPlanet });
                }
                else if (!myDic.ContainsKey("destroyed") && attackName == "D")
                {
                    myDic.Add("destroyed", new List<Planet> { currentPlanet });
                }
                else if (myDic.ContainsKey("attacked") && attackName == "A")
                {
                    myDic["attacked"].Add(currentPlanet);
                }
                else if (myDic.ContainsKey("destroyed") && attackName == "D")
                {
                    myDic["destroyed"].Add(currentPlanet);
                }
            }
        }

        PrintPlanets(myDic, "attacked");
        PrintPlanets(myDic, "destroyed");
    }

    static string DecryptMessage(string encryptedMessage, int count)
    {
        char[] decrypted = new char[encryptedMessage.Length];

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            decrypted[i] = (char)(encryptedMessage[i] - count);
        }

        return new string(decrypted);
    }

    static void PrintPlanets(Dictionary<string, List<Planet>> myDic, string attackType)
    {
        if (myDic.ContainsKey(attackType))
        {
            Console.WriteLine($"{char.ToUpper(attackType[0]) + attackType.Substring(1)} planets: {myDic[attackType].Count}");
            foreach (var planet in myDic[attackType].OrderBy(p => p.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }
        }
        else
        {
            Console.WriteLine($"{char.ToUpper(attackType[0]) + attackType.Substring(1)} planets: 0");
        }
    }
}

class Planet
{
    public Planet(string planetName, string planetPopulation, string atackName, string soldierCount)
    {
        Name = planetName;
        PlanetPopulation = planetPopulation;
        AttackName = atackName;
        SoldierCount = soldierCount;
    }

    public string Name { get; set; }
    public string PlanetPopulation { get; set; }
    public string AttackName { get; set; }
    public string SoldierCount { get; set; }

}