using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startN = int.Parse(Console.ReadLine());
            if (startN > 10)
            {
                Console.WriteLine($"{n} X {startN} = {n * startN}");
                
            }
            if (startN <= 10)
            {
                for (int i = startN; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }

        }
    }
}
