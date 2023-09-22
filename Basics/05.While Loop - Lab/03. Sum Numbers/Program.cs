using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());
            int sumOfNUmbers = 0;
            while (sumOfNUmbers < initialNumber)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfNUmbers += currentNumber;
                
            }
            Console.WriteLine(sumOfNUmbers);
        }
    }
}
