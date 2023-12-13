double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

Dictionary<double,int> occurences =  new Dictionary<double,int>();

foreach (var d in input)
{
    if (!occurences.ContainsKey(d))
    {
        occurences.Add(d, 0);
    }

    occurences[d]++;
}

foreach (var occurence in occurences)
{
    Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
}