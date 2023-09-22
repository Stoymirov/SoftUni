using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceFor20kg = double.Parse(Console.ReadLine());
            double Kg = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countOfBags = int.Parse(Console.ReadLine());
            double price = 0;

            if (Kg >10 && Kg <20)
            {
                price = priceFor20kg / 2;
            }
            else if (Kg <10 )
            {
                price = priceFor20kg * 0.2;
            }
            else if (Kg >20)
            {
                price = priceFor20kg;
            }
            if (days >30)
            {
                price *= 1.1;
            }
            else if (days <30 &&days>7) 
            {
                price *= 1.15;
            }
            else if (days <7)
            {
                price *= 1.4;
            }
            double totalPrice = price * countOfBags;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
