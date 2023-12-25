//up to n find all numbers that a devisible by the numbers given
int n = int.Parse(Console.ReadLine());
HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

Func<int, List<int>> transformer = s =>
{
    List<int> list = new List<int>();
    for (int i = 1; i <= n; i++)
    {
        list.Add(i);
    }

    return list;
};
List<int> list = transformer(n);
Action<List<int>, Predicate<int>> printer = (listIn, match) =>
{
    foreach (var i in listIn)
    {
      if (match(i))
      {
          Console.Write(i + " ");
      }
    }
};
Predicate<int> prediacate = s =>
{
    bool trulian = true;
    foreach (var divider in dividers)
    {
        if (s % divider != 0)
        {
            trulian = false;
            break;
        }
    }
    return trulian;
};
printer(list,prediacate);