using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int flowerNumber = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double price = 0;
            if (typeOfFlower == "Roses")
            {
                price = 5;
                if (flowerNumber > 80)
                {
                    price *= 0.9;
                }
            }
            else if (typeOfFlower == "Dahlias")
            {
                price = 3.8;
                if (flowerNumber > 90)
                {
                    price *= 0.85;
                }
            }
            else if (typeOfFlower == "Tulips")
            {
                price = 2.8;
                if (flowerNumber > 80)
                {
                    price *= 0.85;
                }
            }
            else if (typeOfFlower == "Narcissus")
            {
                price = 3;
                if (flowerNumber < 120)
                {
                    price *= 1.15;
                }
            }
            else if (typeOfFlower == "Gladiolus")
            {
                price = 2.5;
                if (flowerNumber < 80)
                {
                    price *= 1.2;

                }
            }
            double totalPrice = price * flowerNumber;
            double moneyLeft = Math.Abs(totalPrice - budjet);
           if (budjet >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {typeOfFlower} and {moneyLeft:f2} leva left.");
            }
           else
                Console.WriteLine($"Not enough money, you need {moneyLeft:f2} leva more.");
        }
    }

}