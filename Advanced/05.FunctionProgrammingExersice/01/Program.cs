string[] input = Console.ReadLine().Split();
Action<string[]> writer = s =>
{
    foreach (var s1 in s)
    {
        Console.WriteLine(s1);
    }
};
writer(input);