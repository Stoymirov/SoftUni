using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int statics = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());

            double clothingDiscout = 1;
            if (statics > 150) clothingDiscout = 0.9;
            double totalPrice = 0.1 * budjet + priceForClothing * clothingDiscout * statics;

            if (budjet < totalPrice)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budjet:f2} leva more.");
              }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budjet - totalPrice:f2} leva left.");
            }
        }
  
    }

}
