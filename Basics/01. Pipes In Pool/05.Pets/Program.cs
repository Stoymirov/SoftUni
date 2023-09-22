using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalFood = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());
            double foodEaten = dogFoodPerDay * days + catFoodPerDay * days + turtleFoodPerDay * 0.001 * days;
            if (foodEaten <= totalFood)
            {
                Console.WriteLine($"{Math.Floor(Math.Abs(foodEaten - totalFood))} kilos of food left.");
            }
            else
                Console.WriteLine($"{Math.Ceiling(Math.Abs(totalFood - foodEaten))} more kilos of food are needed.");
        }
        
    }
}
