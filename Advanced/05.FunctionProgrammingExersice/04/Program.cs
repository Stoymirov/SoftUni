int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select((x)=>int.Parse(x)).ToArray();
int lowerEnd = input[0];
int higherEnd = input[1];
string type = Console.ReadLine();
Func<int, int, List<int>> generateRange = (n1, n2) =>
{
    List<int> list = new List<int>();
    for (int i = n1; i <= n2; i++)
    {
        list.Add(i);
    }

    return list;
};
Predicate<string> filter = type =>
{
    if (type == "odd")
    {
        return true;
    }
    else
    {
        return false;
    }
};

Writer(filter,generateRange,lowerEnd,higherEnd, type );
void Writer(Predicate<string> filter, Func<int, int, List<int>> generateRange,int low, int high,string type)
{
    var list = generateRange(low, high);
    bool isOdd = filter(type);
    if (!isOdd)
    {
        list = list.Where(x => x % 2 == 0).ToList();
    }
    else
    {
        list = list.Where(x=>x%2 != 0).ToList();
    }

    Console.WriteLine(string.Join(" ",list));
}
