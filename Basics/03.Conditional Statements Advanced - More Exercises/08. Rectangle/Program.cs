using System;

namespace _08._Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x1 == x && (y >= y1 && y <= y2)) || (x2 == x && (y >= y1 && y <= y2)) || (y1 == y && (x >= x1 && x <= x2)) || (y2 == y && (x >= x1 && x <= x2)))
            {
                Console.WriteLine("Border");
            }
            else if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                Console.WriteLine("Inside / Outside");
            }
            else { Console.WriteLine("Inside / Outside"); }
        }
    }
}
