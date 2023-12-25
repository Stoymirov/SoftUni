
//up to n find all numbers that a devisible by the numbers given
int n = int.Parse(Console.ReadLine());
HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

List<int> list = Enumerable.Range(1, n).ToList();

List<Predicate<int>> predicates = new();

foreach (var i in dividers)
{
    predicates.Add(z => z % i == 0);
}

Action<List<Predicate<int>>, List<int>> printer = (predicatess, listt) =>
{
    foreach (var i in list)
    {
        bool isAcurate = true;
        foreach (var predicate in predicates)
        {
            if (!predicate(i))
            {
                isAcurate = false;
                break;
            }

        }
        if (isAcurate)
        {
            Console.WriteLine(i + " ");
        }
    }
};
printer(predicates, list);