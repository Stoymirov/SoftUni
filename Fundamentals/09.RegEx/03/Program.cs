using System.Text.RegularExpressions;

string regex = @"\b(?<day>\d{2})([-/.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

string datesStrings = Console.ReadLine();

MatchCollection dates = Regex.Matches(datesStrings, regex);

foreach (Match date in dates)
{
    string dayValue = date.Groups["day"].Value;
    string monthValue = date.Groups["month"].Value;
    string yearValue = date.Groups["year"].Value;
    Console.WriteLine($"Day: {dayValue}, Month: {monthValue}, Year: {yearValue}");
}
