using System;
using System.Xml.Schema;

namespace _09.Weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallArea1 = 2 * x * y + 2 * x * x;
            double windowsArea = 2 * 1.5 * 1.5;
            double wallArea = 1.2 * 2;

            double wallArea2 = wallArea1 - (windowsArea + wallArea);
            double wallArea2Liters = wallArea2 / 3.4;
            double roofArea = h * x + 2 * x * y;
            double roofAreaLiters = roofArea / 4.3;

            Console.WriteLine($"{0:f2}", wallArea2Liters);
                
            Console.WriteLine($"{0:f2}", roofAreaLiters);

        }
    }
}
