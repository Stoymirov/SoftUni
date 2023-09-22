using System;
using System.Runtime.ConstrainedExecution;

namespace Conditional_Statements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());

            int sum = s1 + s2 + s3;

            int minutes = sum / 60;
            double seconds = sum % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
