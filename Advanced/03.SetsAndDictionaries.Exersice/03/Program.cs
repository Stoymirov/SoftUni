int n = int.Parse(Console.ReadLine());
HashSet<string> elements = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    foreach (var s in input)
    {
        elements.Add(s);
    }
}
//elements = elements.OrderBy(x=>x).ToHashSet();
Console.WriteLine(string.Join(" ",elements.OrderBy(x => x).ToHashSet()));