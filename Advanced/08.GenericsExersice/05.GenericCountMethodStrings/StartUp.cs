using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

int n = int.Parse(Console.ReadLine());
List<string> valuesList = new List<string>();
for (int i = 0; i < n; i++)
{
    string values = Console.ReadLine();
    valuesList.Add(values);
}
string valueToCompare = Console.ReadLine();
Console.WriteLine(Returner(valuesList, valueToCompare));
int Returner<T>(List<T> list, string valueToCompare) where T : IComparable
{
    int count = default;
    foreach (var comparable in list)
    {
        if (comparable.CompareTo(valueToCompare) > 0)
            count++;
    }
    return count;
}