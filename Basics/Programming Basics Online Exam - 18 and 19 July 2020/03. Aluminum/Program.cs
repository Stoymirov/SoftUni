using System;

namespace _03._Aluminum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string typeOfDelivery = Console.ReadLine();
            double price = 0;
            if (number < 10)
            {
                Console.WriteLine("Invalid order");
            }
            if (type == "90X130")
            {
                
                if (number >60)
                {
                    price = number * 110 * 0.92;
                }
                else if (number >30)
                {
                    price = number * 110 * 0.95;
                }
                else
                    price = number * 110;
            }
            if (type == "100X150")
            {
                if (number > 80)
                {
                    price = number * 140 * 0.9;
                }
                else if (number > 40)
                {
                    price = number * 140 * 0.94;
                }
                else
                    price = number * 140;
            }
            if (type == "130X180")
            {
                if (number > 50)
                {
                    price = number * 190 * 0.88;
                }
                else if (number > 20)
                {
                    price = number * 190 * 0.93;
                }
                else price = number * 190;
            }
            if (type == "200X300")
            {
                if (number > 50)
                {
                    price = number * 250 * 0.86;
                }
                else if (number > 25)
                {
                    price = number * 250 * 0.91;
                }
                else price = number * 250;
            }
            if (typeOfDelivery =="With delivery" && number >=10)
            {
                price += 60;
            }
            if (number >= 100)
            {
                price *= 0.96;
            }
           if (number>=10) Console.WriteLine($"{price:f2} BGN");
        }
    }
}
