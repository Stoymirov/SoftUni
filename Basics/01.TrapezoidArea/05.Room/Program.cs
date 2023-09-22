using System;

namespace _05.Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lengthCm = length * 100;
            double widthCm = width * 100;

            //find desks per roll
            double desksARoll = (widthCm - 100) / 70;
            
            double Rolls = lengthCm / 120;
            int Rolls1 = (int)Math.Floor(Rolls); 
            int desksARoll1 = (int)Math.Floor(desksARoll);
            Console.WriteLine(desksARoll1 * Rolls1 - 3);
        }
    }
}
