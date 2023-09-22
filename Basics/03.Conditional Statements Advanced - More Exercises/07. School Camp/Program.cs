using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int studentsNum = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";
            if(gender == "boys" || gender == "girls" )
            {
                switch (season)
                {
                    case "Winter":
                        price = 9.6 * nights; 
                        if (gender == "boys") { sport = "Judo"; }
                        else if (gender == "girls") { sport = "Gymnastics"; }
                        break;
                    case "Summer":
                        price = nights * 15;
                        if (gender == "boys") { sport = "Football"; }
                        else if (gender == "girls") { sport = "Volleyball"; }
                        break;
                    case "Spring":
                        price = (nights * 7.2);
                        if (gender == "boys") { sport = "Tennis"; }
                        else if (gender == "girls") { sport = "Athletics"; }
                        break;

                }
            }
            else if (gender == "mixed")
            {
                switch (season)
                {
                    case "Winter":
                        price = 10 * nights;
                        sport = "Ski";
                        break;
                    case "Summer":
                        price = nights * 20;
                        sport = "Swimming";
                        break;
                    case "Spring":
                        price = (nights * 9.5);
                        sport = "Cycling";
                        break;

                }
            }
            if (studentsNum >= 50)
            {
                price *= 0.5;
            }
            else if (studentsNum >= 20)
            {
                price *= 0.85;
            }
            else if (studentsNum >= 10)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price * studentsNum:f2} lv.");
        }
      
    }
}
