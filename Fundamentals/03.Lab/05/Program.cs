using System.Diagnostics.CodeAnalysis;

int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;

foreach (int n in number)
{
    if (n%2==0)
    {
        sum+= n;
    }
}
Console.WriteLine(sum);

