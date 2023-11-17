using System.Text.RegularExpressions;

string input = Console.ReadLine();
Regex regex =new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

MatchCollection  matches =regex.Matches(input);
foreach (Match VARIABLE in matches)
{
    Console.Write(VARIABLE.Value + " ");
}