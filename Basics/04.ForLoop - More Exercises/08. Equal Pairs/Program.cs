using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double moneyInherited = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            double totalMoneyNeeded = 0;
            for (int i = 1800; i <= yearToLive; i++)
            {
                if( i % 2 == 0)
                {
                    totalMoneyNeeded += 12000;
                }
                else 
                {
                    totalMoneyNeeded += (12000 + 50 * (18 + i -1800));
                }
            }
            if (moneyInherited >= totalMoneyNeeded) 
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Abs(totalMoneyNeeded - moneyInherited):f2} dollars left."); 
            }
            else { Console.WriteLine($"He will need {Math.Abs(totalMoneyNeeded - moneyInherited):f2} dollars to survive."); }
        }
    }
}
