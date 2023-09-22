using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfCoins = 0;
            decimal moneyToStartWith = decimal.Parse(Console.ReadLine());
            while (moneyToStartWith > 0)
            {
                if (moneyToStartWith - 2 >= 0)
                {
                    moneyToStartWith -= 2;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 1 >= 0)
                {
                    moneyToStartWith -= 1;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.5m >= 0)
                {
                    moneyToStartWith -= 0.5m;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.2m >= 0)
                {
                    moneyToStartWith -= 0.2m;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.1m >= 0)
                {
                    moneyToStartWith -= 0.1m;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.05m >= 0)
                {
                    moneyToStartWith -= 0.05m;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.02m >= 0)
                {
                    moneyToStartWith -= 0.02m;
                    sumOfCoins++;
                    continue;
                }
                else if (moneyToStartWith - 0.01m >= 0)
                {
                    moneyToStartWith -= 0.01m;
                    sumOfCoins++;
                    continue;
                }

            }
            Console.WriteLine(sumOfCoins);
        }
    }
}
