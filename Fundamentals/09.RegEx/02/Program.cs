using System.Text.RegularExpressions;

Regex regex = new Regex(@"(?<firstName>[A-Z][a-z]+) ([A-Z][a-z]+)");
string input = "egjnehigrh 24wtbd; Sto Sho woajgoargjergweoji Sto Sho"; 

MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine(match.Groups[1]);
}