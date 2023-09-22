using System;

namespace _07.TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age <0 )
            {
                Console.WriteLine("Error!");
                return;
            }
            if (day == "Weekday")
            {
                if (age <= 18 || (age > 64 && age <=122))
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("18$");
                }
            }
            else if (day == "Weekend")
            {
                if (age <= 18 || (age > 64 && age <= 122))
                {
                    Console.WriteLine("15$");
                }
                else
                {
                    Console.WriteLine("20$");
                }
            }
            else if (day == "Holiday")
            {
                 if (age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age <= 64)
                {
                    Console.WriteLine("12$");
                }
                 else if (age <=122)
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
