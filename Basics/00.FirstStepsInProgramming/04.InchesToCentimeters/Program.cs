using System;

namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write some inches!");
            double inch = double.Parse(Console.ReadLine());

            double result = inch * 2.54;
            Console.WriteLine(result);
        }
    }
}
