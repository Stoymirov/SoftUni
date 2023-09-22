using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.readinput
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //2.sum all toys
            int toyscount = puzzles + dolls + bears + minions + trucks;

            //3. calculate profit
            double profit = puzzles * 2.60 + dolls * 3 + bears * 4.1 + minions * 8.20 + trucks * 2;

            //4. if discout should apply, apply
            if (toyscount >= 50)
            {
                profit = 0.75 * profit;
            }
            //5. subtract rent money
            profit = 0.9 * profit;
            //6. print out
            if (profit > trip)
            {
                double remainingMoney = profit - trip;
                Console.WriteLine($"Yes! {remainingMoney:f2} lv left.");
            }
            else if (trip > profit)
            {
                double neededMoney = Math.Abs(profit - trip);
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");

            }
        }
    }
}
