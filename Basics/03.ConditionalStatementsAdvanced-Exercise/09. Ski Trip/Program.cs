using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            double apartmentPrice = 25;
            double roomPrice = 18;
            double presidentApartmentPrice = 35;
            int nights = days - 1;
            double price = 0;
            if (nights < 10)
            {
                if (room == "apartment")
                    price = apartmentPrice * 0.7;
                else if (room == "president apartment")
                    price = presidentApartmentPrice * 0.9;
                else if (room == "room for one person")
                    price = 18;
            }
            else if (nights >= 10 && nights <=15)
            {
                if (room == "apartment")
                    price = apartmentPrice * 0.65;
                else if (room == "president apartment")
                    price = presidentApartmentPrice * 0.85;
                else if (room == "room for one person")
                    price = 18;
            }
            else 
            {
                if (room == "apartment")
                    price = apartmentPrice * 0.5;
                else if (room == "president apartment")
                    price = presidentApartmentPrice * 0.8;
                else if (room == "room for one person")
                price = 18;
            }

            switch (rating)
            {
                case "positive":
                    price *= 1.25;
                    break;
                case "negative":
                    price *= 0.90;
                    break;
               
            }
            double totalPrice = price * nights;
            
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
