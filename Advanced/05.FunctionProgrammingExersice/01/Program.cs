List<string> input = Console.ReadLine().Split();
Action<List<string>> writer = s =>
{
    foreach (var s1 in s)
    {
        Console.WriteLine(s1);
    }
};
writer(input);