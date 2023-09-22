using System;

namespace _05._Number100to200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input <100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (input > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (input >= 100) 
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
