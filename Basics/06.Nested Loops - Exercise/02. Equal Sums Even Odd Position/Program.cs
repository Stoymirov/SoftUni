using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int n = i;
                int sumEven = 0;
                int sumOdd = 0;
                bool b = true;

                while (n != 0)
                {
                    int lastDigic = n % 10;
                    if (b)
                    {
                        sumEven += lastDigic;
                    }
                    else if (!b)
                    {
                        sumOdd += lastDigic;
                    }
                    n /= 10;
                    b = !b;
                }
                if (sumEven ==sumOdd)
                {
                    Console.Write($"{i} ");
                }
            }
            

        }
    }
}
