using System;

namespace _01.AgencyProf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int ticketsForAdults = int.Parse(Console.ReadLine());
            int ticketsForChildren = int.Parse(Console.ReadLine());
            double priceForAdultNeto = double.Parse(Console.ReadLine());
            double priceForAssistance = double.Parse(Console.ReadLine());
            double priceForChildrenNeto = 0.3 * priceForAdultNeto;
            double totalPrice = priceForAdultNeto*ticketsForAdults + priceForChildrenNeto*ticketsForChildren + (ticketsForAdults+ticketsForChildren)*priceForAssistance;
            double profit = totalPrice * 0.2;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit} lv.");
            //            1.Име на авиокомпанията -текст
            //2.Брой билети за   възрастни – цяло число в диапазона[1…400]
            //3.Брой детски билети – цяло число в диапазона[25…120]
            //4.Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
            //5.Цената на такса обслужване - реално число в диапазона[10.0…50.0]

        }
    }
}
