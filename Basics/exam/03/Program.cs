using System;
using System.Transactions;

namespace _03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = Console.ReadLine();
            double moneyWon = 0; ;
            if (location == "Bulgaria")
            {
                 moneyWon = dancers * points;
                if (season == "summer")
                {
                    moneyWon *= 0.95;
                }
                 else if (season == "winter")
                {
                    moneyWon *= 0.92;
                }
            }
            else if (location =="Abroad")
            {
                moneyWon= dancers * points *1.5;
                if (season == "summer")
                {
                    moneyWon *= 0.9;
                }
                else if (season == "winter")
                {
                    moneyWon *= 0.85;
                }
            }
            double moneyForDonation = moneyWon * 0.75;
            double moneyForDancer = (moneyWon * 0.25) / dancers;
            Console.WriteLine($"Charity - {moneyForDonation:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancer:f2}");
        }
    }
}
