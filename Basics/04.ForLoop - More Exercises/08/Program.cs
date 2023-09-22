using System;
using System.Transactions;

namespace _08_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int maxDiff = int.MinValue;
            int sum = 0;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
                int previumSum = num1 + num2;
            for (int i = 0; i < input - 1; i++) 
            {
                int num11 = int.Parse(Console.ReadLine());
                int num22 = int.Parse(Console.ReadLine());
                int currentSum = num11 + num22;
                if (previumSum != currentSum) 
                {
                    
                    int tempDiff = Math.Abs(previumSum - currentSum);
                    previumSum = currentSum;
                    if (tempDiff > maxDiff)
                    {
                        maxDiff = tempDiff;
                    }
                }
            }
            if (maxDiff != int.MinValue)
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
            else
                Console.WriteLine($"Yes, value={previumSum}");

        }
    }
}
