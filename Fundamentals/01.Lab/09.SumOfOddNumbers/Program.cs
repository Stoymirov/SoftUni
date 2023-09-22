using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int cn = i * 2 - 1;
                Console.WriteLine(cn);
                sum += cn;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
