﻿using System;

namespace _03.Harsvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            if (kilometers < 20)
            {
                if (timeOfDay == "day")
                    Console.WriteLine($"{0.70 + 0.79 * kilometers:f2}");
                else if (timeOfDay == "night")
                    Console.WriteLine($"{0.7 + 0.9 * kilometers:f2}");
            }
            else if (kilometers < 100)
                Console.WriteLine($"{0.09 * kilometers:f2}");
            else if (kilometers >=100)
                    Console.WriteLine($"{0.06 * kilometers:f2}");
            //            Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:
            //•	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            //Напишете програма, която въвежда броя километри n и период от деня(ден или нощ) и изчислява цената на най - евтиния транспорт.
            //Вход
            //От конзолата се четат два реда:
            //•	Първият ред съдържа числото n – брой километри – цяло число в интервала[1…5000]
            //•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
            //Изход
            //Да се отпечата на конзолата най - ниската цена за посочения брой километри, форматирана до втория знак след десетичния разделител.

        }
    }
}