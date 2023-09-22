using System;

namespace _03.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = int.Parse(Console.ReadLine());
            if (myInt % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
                 

        }
    }
}
