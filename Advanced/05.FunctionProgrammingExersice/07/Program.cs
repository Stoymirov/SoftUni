int n = int.Parse(Console.ReadLine());
List<string> list = Console.ReadLine().Split().ToList();
Func<List<string>, Predicate<string>, List<string>> func = (people, pred) =>
    {
        List<string> newList = new List<string>();
        foreach (var VARIABLE in people)
        {
            if (pred(VARIABLE))
                newList.Add(VARIABLE);
        }
        return newList;
    };
list = func(list, s => s.Length <= n);
Action<List<string>> printer = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
};
printer(list);