
using GenericCountMethodDouble;
using System;

int n = int.Parse(Console.ReadLine());
Box<double> box = new();

for (int i = 0; i<n; i++)
{
    double item =double.Parse( Console.ReadLine());
    box.Add(item);
}

double itemToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(box.Count(itemToCompare));


