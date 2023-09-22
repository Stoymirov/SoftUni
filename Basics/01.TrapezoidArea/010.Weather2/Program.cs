using System;

namespace _010.Weather2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = double.Parse(Console.ReadLine());

            if (myDouble >= 26.00 & myDouble <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (myDouble >= 20.1 & myDouble <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (myDouble >= 15.00 & myDouble <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (myDouble >= 12.00 & myDouble <= 14.90)
            {
                Console.WriteLine("Cool");
            }
            else if (myDouble >= 5.00 & myDouble <= 11.90)
            {
                Console.WriteLine("Cold");
            }

            else
            {
                Console.WriteLine("unknown");
            }
            
            

        }
    }
}

