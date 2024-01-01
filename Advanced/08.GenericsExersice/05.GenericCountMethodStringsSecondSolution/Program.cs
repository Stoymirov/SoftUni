using GenericCountMethodStrings;
using System;

int n = int.Parse(Console.ReadLine());
Box<string> box = new();

for (int i = 0; i<n; i++)
{
    string item = (Console.ReadLine());
    box.Add(item);
}

string itemToCompare = Console.ReadLine();

Console.WriteLine(box.Count(itemToCompare));

