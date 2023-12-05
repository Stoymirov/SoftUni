using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
Regex regexBoss = new Regex(@"\|(?<BOSS>[A-Z]{4,})\|\:\#(?<TITLE>[A-Za-z]+ [A-Za-z]+)\#");
for (int i = 0; i < n; i++)
{
    Match match = regexBoss.Match(Console.ReadLine());
    if (match.Success)
    {
        Console.WriteLine($"{match.Groups["BOSS"].Value}, The {match.Groups["TITLE"].Value}");
        Console.WriteLine($">> Strength: {match.Groups["BOSS"].Value.Length}");
        Console.WriteLine($">> Armor: {match.Groups["TITLE"].Value.Length}");
    }
    else
    {
        Console.WriteLine("Access denied!");
    }
}
