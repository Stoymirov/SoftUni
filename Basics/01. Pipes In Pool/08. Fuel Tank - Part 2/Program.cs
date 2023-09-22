using System;
using System.ComponentModel.Design;
using System.Xml.Schema;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            string type = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double totalPrice = 0;
            if (card == "Yes")
            {
                if (type == "Gas")

                {
                    gas = 0.85;
                }
                else if (type == "Diesel")
                {
                    diesel = 2.33 - 0.12;
                }
                else if (type == "Gasoline")
                {
                    gasoline = 2.04;
                }
            }
            

            if (type == "Gas")
                totalPrice = gas * liters;
            else if (type == "Gasoline")
                totalPrice = gasoline * liters;
            else if (type == "Diesel")
                totalPrice = diesel * liters;

            if (liters > 25)
                totalPrice *= 0.9;
            else if (liters >= 20)
                totalPrice *= 0.92;
        

            Console.WriteLine($"{totalPrice:f2} lv.");





            //            Напишете програма, която да изчислява, колко ще струва на един шофьор да напълни резервоара на автомобила си, като знаете – какъв тип гориво зарежда, каква е цената за литър гориво и дали разполага с карта за отстъпки. Цените на горивата са както следва: 
            //•	Бензин – 2.22 лева за един литър,
            //•	Дизел – 2.33 лева за един литър
            //•	Газ – 0.93 лева за литър
            //Ако водача има карта за отстъпки,  той се възползва от следните намаления за литър гориво: 18 ст.за литър бензин, 12 ст.за литър дизел и 8 ст.за литър газ.
            //Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.
            //Вход
            //Входът се чете от конзолата и се състои от 3 реда:
            //•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            //•	Количество гориво – реално число в интервала[1.00 … 50.00]
            //•	Притежание на клубна карта – текст с възможности: "Yes" или "No"
            //Изход
            //На конзолата трябва да се отпечата един ред.
            //•	"{крайната цена на горивото} lv."
            //Цената на горивото да бъде форматираната до втората цифра след десетичния знак.

        }
    }
}
