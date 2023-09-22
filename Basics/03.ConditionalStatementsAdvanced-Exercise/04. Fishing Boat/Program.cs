using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double ferryPrice = 0;
            if (season == "Spring")
            {
                ferryPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                ferryPrice = 4200;
            }
            else  if (season == "Winter")
            {
                ferryPrice = 2600;
            }
            if (fishermanCount <= 6)
            {
                ferryPrice *= 0.9;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                ferryPrice *= 0.85;
            }
            else
                ferryPrice *= 0.75;

            if (fishermanCount % 2 == 0 && season != "Autumn")
                ferryPrice *= 0.95;

            double leftMoney = Math.Abs(budjet - ferryPrice);
            if (budjet >= ferryPrice)
            {
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
                Console.WriteLine($"Not enough money! You need {leftMoney:f2} leva.");
            //            Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб.Цената за наема на кораба зависи от сезона и броя рибари.
            //Цената зависи от сезона:
            //•	Цената за наем на кораба през пролетта е  3000 лв.
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.
            //В зависимост от броя си групата ползва отстъпка:
            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
            //Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари. 
            //Вход
            //От конзолата се четат точно три реда.
            //•	Бюджет на групата – цяло число в интервала[1…8000]
            //•	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            //•	Брой рибари – цяло число в интервала[4…18]
            //Изход
            //Да се отпечата на конзолата един ред:
            //•	Ако бюджетът е достатъчен:
            //"Yes! You have {останалите пари} leva left."
            //•	Ако бюджетът НЕ Е достатъчен:

        }
    }
}
