double[] input = Console.ReadLine().Split(", ").Select((x) => double.Parse(x)).Select(x=>x*1.2).ToArray();
foreach (var d in input)
{
    Console.WriteLine($"{d:f2}");
}