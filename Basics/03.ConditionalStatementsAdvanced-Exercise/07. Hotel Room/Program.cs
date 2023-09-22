using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;
            bool isMayOrOct = month == "May" || month == "October";
           
            if (isMayOrOct)
            {
                studioPrice = 50;
                apartamentPrice = 65;
            }
            if (month == "June" || month == "September")
            {
                studioPrice = 75.2;
                apartamentPrice = 68.7;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                    apartamentPrice = 77;
            }
            double totalPriceStudioNoDis = nights * studioPrice;
            double totalPriceApartamentNoDis = nights * apartamentPrice;
            if (nights > 14 && isMayOrOct)
            {
                totalPriceStudioNoDis *= 0.7;
            }
            else if ( nights >7 && isMayOrOct)
            {
                totalPriceStudioNoDis *= 0.95;
            }
           
            else if ( nights >14 && (month == "June" || month == "September"))
            {
                totalPriceStudioNoDis *= 0.8;
            }
            if (nights >14)
            {
                totalPriceApartamentNoDis *= 0.9;
            }
            Console.WriteLine($"Apartment: {totalPriceApartamentNoDis:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudioNoDis:f2} lv.");
        }
    }
}
//code snippet for if - s