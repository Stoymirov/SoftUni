using System;
using System.Collections.Generic;
int counter  =0;
HashSet<int> nums = new HashSet<int>();

while (nums.Count < 10)
{
    try
    {
      int n =ReadNumber(nums.Count>0?nums.Max():1, 100);
        nums.Add(n);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

Console.WriteLine(string.Join(", ",nums));

int ReadNumber(int start, int end)
{
    int n = 0;
    try
    {
         n = int.Parse(Console.ReadLine());
    }
    catch
    {
        throw new Exception("Invalid Number!");
    }

    if (n <= start || n >= end)
    {
        throw new Exception($"Your number is not in range {start} - {end}!");
    }
    

    return n;
}