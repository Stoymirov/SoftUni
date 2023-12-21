using System;
using System.Collections.Generic;

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
HashSet<int> numbers1 = new HashSet<int>();
HashSet<int> numbers2 = new HashSet<int>();
for (int i = 0; i < array[0]; i++)
{
    numbers1.Add(int.Parse(Console.ReadLine()));
}
for (int i = 0; i < array[1]; i++)
{
    numbers2.Add(int.Parse(Console.ReadLine()));
}

//foreach (var i in numbers1)
//{
//    foreach (var i1 in numbers2)
//    {
//        if (i == i1)
//        {
//            Console.Write(i+ " ");
//        }
//    }
//}
var list = numbers1.Intersect(numbers2).ToList();
Console.WriteLine(string.Join(" ",list));