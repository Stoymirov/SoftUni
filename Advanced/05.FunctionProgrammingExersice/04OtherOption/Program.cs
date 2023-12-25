List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select((x) => int.Parse(x)).ToArray();
int lowerEnd = input[0];
int higherEnd = input[1];
string type = Console.ReadLine();
Func<int, int, List<int>> generateRange = (n1, n2) =>
{
    List<int> list = new();
    for (int i = n1; i <= n2; i++)
    {
        list.Add(i);
    }

    return list;
};
Predicate<int> filter;

List<int> generated = generateRange(lowerEnd, higherEnd);
if (type == "even")
{
    filter = s => s % 2 == 0;
}
else
{
    filter = s => s % 2 != 0;

}

foreach (var VARIABLE in generated)
{
    if (filter(VARIABLE))
    {
        Console.Write($"{VARIABLE} ");
    }
}