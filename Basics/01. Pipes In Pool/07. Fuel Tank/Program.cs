using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            
            
                if (type == "Gasoline")
                {
                    if (liters >= 25)
                        Console.WriteLine($"You have enough gasoline.");
                    else
                        Console.WriteLine($"Fill your tank with gasoline!");
                }
                else if (type == "Gas")
                {
                    if (liters >= 25)
                        Console.WriteLine($"You have enough gas.");
                    else
                        Console.WriteLine($"Fill your tank with gas!");
                }
                else if (type == "Diesel")
                {
                    if (liters >= 25)
                        Console.WriteLine($"You have enough diesel.");
                    else
                        Console.WriteLine($"Fill your tank with diesel!");
                }
                else 
            
                Console.WriteLine("Invalid fuel!");
        }
    }
}
