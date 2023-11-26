using System.Text.RegularExpressions;

Regex pattern = new Regex(@"(=|\/)(?<myMatch>[A-Z][A-Za-z]{2,})\1");


string input = Console.ReadLine();
List<string> output = new List<string>();
MatchCollection matchCollection = pattern.Matches(input);
foreach (Match match in matchCollection)
{
    string myMatch = match.Groups["myMatch"].Value;
    output.Add(myMatch);
}

int sum = output.Sum(x=>x.Length);
Console.WriteLine($"Destinations: {string.Join(", ", output)}");
Console.WriteLine($"Travel Points: {sum}");