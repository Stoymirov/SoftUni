int n = int.Parse(Console.ReadLine());
List<string> list = Console.ReadLine().Split().ToList();

Action<List<string>, Predicate<string>> printer = (names, match) =>
{
    foreach (var name in names)
    {
        if (match(name))
            Console.WriteLine(name);
    }
};
printer(list, s => s.Length <= n);
