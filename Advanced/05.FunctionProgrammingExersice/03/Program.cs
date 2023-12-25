List<int> input = Console.ReadLine().Split().Select(int.Parse).ToArray();

myDelegate func = Min;

Console.WriteLine(func(input));

int Min(List<int> input)
{
    int min = int.MaxValue;
    foreach (var i in input)
    {
        if (i < min)
        {
            min = i;
        }

    }
    return min;
}
delegate int myDelegate(List<int> input);