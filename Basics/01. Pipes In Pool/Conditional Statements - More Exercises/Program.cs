
using System;

namespace Conditional_Statements___More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double d1Total = d1 * H;
            double d2Total = d2 * H;
            double poolTotal = d2Total + d1Total;
            if (poolTotal < V)
                Console.WriteLine($"The pool is {poolTotal/V * 100}% full. Pipe 1: {d1Total/poolTotal * 100:f2}%. Pipe 2: {d2Total / poolTotal * 100:f2}%.");
            else
                Console.WriteLine($"For {H:f2} hours the pool overflows with {poolTotal - V:f2} liters.");
            

        }
    }
}
