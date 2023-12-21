using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
int n = int.Parse(Console.ReadLine());
stopwatch.Start();
SortedSet<string> elements = new SortedSet<string>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    elements.UnionWith(input);
}
//elements = elements.OrderBy(x=>x).ToHashSet();
stopwatch.Stop();
Console.WriteLine(string.Join(" ", elements));
Console.WriteLine(stopwatch.ElapsedMilliseconds);