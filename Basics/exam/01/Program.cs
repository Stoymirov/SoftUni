using System;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleGroupNumber = int.Parse(Console.ReadLine());
            int nightsNumber = int.Parse(Console.ReadLine());
            int transportCardsNumber = int.Parse(Console.ReadLine());
            int MuseumCardsNumber = int.Parse(Console.ReadLine());
            double priceForNights = 20 * nightsNumber * peopleGroupNumber;
            double priceForTransport = 1.6 * transportCardsNumber * peopleGroupNumber;
            double priceForMuseum = 6 * MuseumCardsNumber * peopleGroupNumber;
            double totalPrice = priceForNights + priceForTransport + priceForMuseum;
            totalPrice *= 1.25;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
