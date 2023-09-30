using System;

int[] array1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] array2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;

bool Identical = true;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] != array2[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index"
);
        Identical = false;
        break;
    }
    sum += array1[i];
}
if (Identical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
