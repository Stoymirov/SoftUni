using System;
using System.Runtime.CompilerServices;
using BoxOfInteger;

int n = int.Parse(Console.ReadLine());
Box<string> box = new();

for (int i = 0; i < n; i++)
{
    var item = Console.ReadLine();
    box.Add(item);
}


Console.WriteLine(box.ToString());