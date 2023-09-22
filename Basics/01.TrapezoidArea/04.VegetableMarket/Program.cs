using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – Цена за килограм зеленчуци – реално число[0.00… 1000.00]
            //•	Втори ред – Цена за килограм плодове – реално число[0.00… 1000.00]
            //•	Трети ред – Общо килограми на зеленчуците – цяло число[0… 1000]
            //•	Четвърти ред – Общо килограми на плодовете – цяло число[0… 1000]

            //input
            double PriceV = double.Parse(Console.ReadLine());
            double PriceF = double.Parse(Console.ReadLine());
            int KgV = int.Parse(Console.ReadLine());
            int KgF = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", (PriceV * KgV + PriceF * KgF) * 1.00 / 1.94);


        }
    }
}
