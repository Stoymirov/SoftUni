SortedDictionary<double, int> counts =  new SortedDictionary<double,int>();

List<int> inputList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
foreach (int intiger in inputList)
{
    if (!counts.ContainsKey(intiger))
    {
        counts.Add(intiger, 1);

    }
    else
    {
        counts[intiger]++;
    }
}

foreach (var (number,repetition) in counts)
{
    Console.WriteLine($"{number} -> {repetition}");
}