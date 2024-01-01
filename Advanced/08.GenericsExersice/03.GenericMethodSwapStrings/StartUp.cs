using System.Runtime.CompilerServices;
using System;
using System.Linq;
using GenericMethodSwapStrings;

int n = int.Parse(Console.ReadLine());
Box<string> box = new();

for (int i = 0; i<n; i++)
{
    var item = Console.ReadLine();
    box.Add(item);
}
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index1 = array[0];
int index2 = array[1];
box.Swap(index1, index2);

Console.WriteLine(box.ToString());
