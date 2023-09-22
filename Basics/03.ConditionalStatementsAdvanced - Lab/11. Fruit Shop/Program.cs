using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            bool weekToFriday = dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday";
            bool weekToSunday = dayOfWeek == "Saturday" || dayOfWeek == "Sunday";
            if (weekToFriday)
            {
                switch (fruit)
                {
                    case "banana":
                        totalPrice = amount * 2.5;
                        break;
                    case "apple":
                        totalPrice = amount * 1.2;
                        break;
                    case "orange":
                        totalPrice = amount * 0.85;
                            break;
                    case "grapefruit":
                        totalPrice = amount * 1.45;
                        break;
                    case "kiwi":
                        totalPrice = amount * 2.7;
                        break;
                    case "pineapple":
                        totalPrice = amount * 5.5;
                        break;
                    case "grapes":
                        totalPrice = amount * 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (weekToSunday)
            {
                switch (fruit)
                {
                    case "banana":
                        totalPrice = amount * 2.7;
                        break;
                    case "apple":
                        totalPrice = amount * 1.25;
                        break;
                    case "orange":
                        totalPrice = amount * 0.9;
                        break;
                    case "grapefruit":
                        totalPrice = amount * 1.6;
                        break;
                    case "kiwi":
                        totalPrice = amount * 3;
                        break;
                    case "pineapple":
                        totalPrice = amount * 5.6;
                        break;
                    case "grapes":
                        totalPrice = amount * 4.2;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
                Console.WriteLine("error");
            if (totalPrice != 0)
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
