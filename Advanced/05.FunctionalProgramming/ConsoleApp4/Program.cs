double[] input = Console.ReadLine().Split(", ").Select((x)=>double.Parse(x)).ToArray();

Func<double, double> func = Funcc(0.2);
double[] worked = input.Select(x=>func(x)).ToArray();
Func<double, double> Funcc(double d)
{
    return x => x * (1 + d);
}

foreach (var d in worked)
{
    Console.WriteLine($"{d:f2}");
}