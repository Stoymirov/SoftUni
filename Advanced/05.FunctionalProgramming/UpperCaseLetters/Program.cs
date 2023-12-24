
Predicate<string> filterUpperCase = s => s[0] == char.ToUpper(s[0]) && char.IsLetter(s[0]);
string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Where(s=>filterUpperCase(s)).ToArray();

foreach (var s in input)
{
    Console.WriteLine(s);
}