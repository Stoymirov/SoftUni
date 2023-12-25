using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
int divider = int.Parse(Console.ReadLine());
Func<List<int>, List<int>> reverse = x =>
{
    List<int> newArray = new();
    for (int i = x.Count - 1; i >= 0; i--)
    {
        newArray.Add(x[i]);
    }

    return newArray;
};
array = reverse(array);
Func<List<int>, Predicate<int>, List<int>> excludeDivisible = (numbers, match) =>
{
    List<int> list = new();
    foreach (var number in numbers)
    {
        if (match(number))
            list.Add(number);
    }

    return list;
};
array = excludeDivisible(array, s => s % divider != 0);
foreach (int VARIABLE in array)
{
    Console.Write(VARIABLE+ " ");
}