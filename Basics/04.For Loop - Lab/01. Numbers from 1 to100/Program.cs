using System;

namespace _01._Numbers_from_1_to100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int i = 1; i <= number; i++)
            {
                int numberr = int.Parse(Console.ReadLine());
                sumOfNumbers += numberr;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
