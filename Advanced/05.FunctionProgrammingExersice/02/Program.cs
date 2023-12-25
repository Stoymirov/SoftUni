string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

Action<string[],string> writer = (s,title)=>
{
    foreach (var s1 in s)
    {
        Console.WriteLine($"{title} {s1}");
    }

    
};
writer(input,"Sir");
