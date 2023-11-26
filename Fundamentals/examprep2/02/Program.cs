using System.Collections.Immutable;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

UInt64 threshHold = 1;
int countOfMatches = 0;
List<string> matchesList = new List<string>();

string input = Console.ReadLine();

Regex regex = new Regex(@"(::|\*\*)(?<groupa>[A-Z][a-z]{2,}\1)|(?<digits>\d)");
MatchCollection matches = regex.Matches(input);


string[] arrays = matches.Cast<Match>().SelectMany(x=>x.Groups["digits"].Captures.Cast<Capture>().Select(x=>x.Value)).ToArray();
foreach (var match in arrays)
{
    threshHold *= Convert.ToUInt64(match);

}

string[] arrass =matches.Cast<Match>().SelectMany(x => x.Groups["groupa"].Captures.Cast<Capture>().Select(x => x.Value)).ToArray();
foreach (var VARIABLE in arrass)
{
    UInt64 curr = 0;
    foreach (var varr in VARIABLE)
    {
        curr += varr;
    }

    if (curr > threshHold)
    {
        matchesList.Add(VARIABLE.ToString());
    }
}
Console.WriteLine($"Cool threshhold: {threshHold}");
Console.WriteLine($"{arrass.Length} emojis found in the text. The cool ones are:");
foreach (var VARIABLE in matchesList)
{
    Console.WriteLine(VARIABLE);
}

