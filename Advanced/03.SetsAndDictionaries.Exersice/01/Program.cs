int n = int.Parse(Console.ReadLine());
HashSet<string> name = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    name.Add(Console.ReadLine());
}

foreach (var VARIABLE in name)
{
    Console.WriteLine(VARIABLE);
}