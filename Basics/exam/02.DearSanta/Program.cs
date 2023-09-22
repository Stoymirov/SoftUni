using System;
using System.Xml.Schema;

namespace _02.DearSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double day1Food = double.Parse(Console.ReadLine());
            double day2Food = double.Parse(Console.ReadLine());
            double day3Food = double.Parse(Console.ReadLine());
            double totalEatenFood = (day1Food + day2Food + day3Food) * days;
            if (totalEatenFood > foodLeft) 
            {
                Console.WriteLine($"{Math.Ceiling(-foodLeft + totalEatenFood)} more kilos of food are needed.");
                }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft-totalEatenFood)} kilos of food left."
                    );
            }
        }
    }
}
