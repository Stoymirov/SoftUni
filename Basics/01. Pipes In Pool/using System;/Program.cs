using System;

namespace ejeoe
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
            double foodEaten = dogFoodPerDay * days + catFoodPerDay * days + turtleFoodPerDay * days;
            if (foodEaten >= totalFood)
            {
                Console.WriteLine($"{Math.Floor(totalFood - foodEaten)} kilos of food left.");
            }
            else
                Console.WriteLine($"{Math.Ceiling(foodEaten - totalFood)} more kilos of food are needed.");
        }
    }
}
