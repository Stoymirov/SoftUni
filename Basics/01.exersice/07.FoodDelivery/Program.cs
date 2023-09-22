using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int Chicken = int.Parse(Console.ReadLine()); 
          int Fish = int.Parse(Console.ReadLine()); 
          int Vegetarian = int.Parse(Console.ReadLine());

            double ChickenPrice = Chicken * 10.35;
            double FishPrice = Fish * 12.4;
            double VegetarianPrice = Vegetarian * 8.15;
          double dessertPrice = 0.2 * (ChickenPrice + FishPrice + VegetarianPrice);
            Console.WriteLine( ChickenPrice + FishPrice+ VegetarianPrice +dessertPrice + 2.5);
        }
    }
}
