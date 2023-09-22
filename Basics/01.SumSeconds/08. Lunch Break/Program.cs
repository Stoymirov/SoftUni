using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());

            double lunchTime = 0.125 * rest;
            double otdih = 0.25 * rest;
           if (rest >= lunchTime + otdih + duration)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(rest - lunchTime -  otdih - duration) } minutes free time.");
            }
           else
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(lunchTime + otdih + duration - rest)} more minutes.");
            //            8.Обедна почивка
            //По време на обедната почивка искате да изгледате епизод от своя любим сериал. Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно време да изгледате епизода. По време на почивката отделяте време за обяд и време за отдих. Времето за обяд ще бъде 1 / 8 от времето за почивка, а времето за отдих ще бъде 1 / 4 от времето за почивка. 
            //Вход
            //От конзолата се четат 3 реда:
            //            1.Име на сериал – текст
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120]
            //Изход
            //На конзолата да се изпише един ред:
            //•	Ако времето е достатъчно да изгледате епизода:
            //            "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            //•	Ако времето не Ви е достатъчно:
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            //Времето да се закръгли до най-близкото цяло число нагоре.

        }
    }
}
