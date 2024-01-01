using System;
using System.Runtime.CompilerServices;
using BoxOfString;

int n = int.Parse(Console.ReadLine());
    Box<string> box = new Box<string>();

for (int i = 0; i < n; i++)
{
    var item = Console.ReadLine();
    box.Add(item);
}

Console.WriteLine(box.ToString());

