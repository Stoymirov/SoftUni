using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            int counter = 0;
           int start = int.Parse(Console.ReadLine());
           int end = int.Parse(Console.ReadLine());
           int magic = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    int sum = j + i;
                    if (sum == magic)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }

                }
                if (isFound)
                {
                    break;
                }

            }
            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
