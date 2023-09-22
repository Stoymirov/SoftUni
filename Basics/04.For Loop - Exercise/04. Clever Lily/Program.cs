using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double Washingmachineprice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyToRecieve = 10;
            int numberOfToys = 0;
            int moneySum = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySum += moneyToRecieve - 1;
                    moneyToRecieve += 10;
                }
                else { numberOfToys++;}
                
            }
            
            moneySum += toyPrice * numberOfToys;
            if (moneySum >= Washingmachineprice)
                Console.WriteLine($"Yes! {(Math.Abs(moneySum - Washingmachineprice)):f2}");
            else Console.WriteLine($"No! {(Math.Abs(moneySum - Washingmachineprice)):f2}");
        }
    }
}
