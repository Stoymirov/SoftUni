using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double neededMoney = double.Parse(Console.ReadLine());
            double moneyToStart = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int SpendCounter = 0;
            while (moneyToStart < neededMoney && SpendCounter <5)
            {
                string activity = Console.ReadLine();
                double currentMoney = double.Parse((Console.ReadLine()));
                daysCounter++;
                if (activity == "spend")
                {
                    SpendCounter++;
                    moneyToStart -= currentMoney;
                    if (moneyToStart <= 0)
                    {
                        moneyToStart = 0;
                    }
                }
                else if (activity == "save")
                {
                    moneyToStart += currentMoney;
                    SpendCounter = 0;
                }
            }
            if (neededMoney <= moneyToStart)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            if (SpendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

        }
    }
}
