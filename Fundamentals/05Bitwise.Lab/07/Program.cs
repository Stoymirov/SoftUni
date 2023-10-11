int[] ints = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int result = 0;

foreach (int i in ints)
{
    result = result^i;
}
Console.WriteLine(result);