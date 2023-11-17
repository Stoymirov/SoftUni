using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern =(@"\+359( |-)2\1\d{3}\1\d{4}\b");

var matches = Regex.Matches(input,pattern);

var matchedPhones = matches.Cast<Match>()
    .Select(x=>x.Value.Trim())
    .ToArray();

Console.WriteLine(string.Join(", ",matchedPhones));