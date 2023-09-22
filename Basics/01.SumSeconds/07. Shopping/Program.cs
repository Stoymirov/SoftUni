using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int vcN = int.Parse(Console.ReadLine());
            int prossesorN = int.Parse(Console.ReadLine());
            int ramN = int.Parse(Console.ReadLine());
            
            int priceVc = vcN * 250;
            double priceProssesors = 0.35 * priceVc * prossesorN;
            double priceRam = ramN * 0.1 * priceVc;

            double totalSum = priceVc + priceProssesors + priceRam;
            if (vcN > prossesorN)
            {
                totalSum *= 0.85;
            }
            if (totalSum <= budjet)
            {
                Console.WriteLine($"You have {budjet - totalSum:f2} leva left!");
            }
            else
                Console.WriteLine($"Not enough money! You need {totalSum - budjet:f2} leva more!");
            //            7.Пазаруване
            //Петър иска да купи N видеокарти, M процесора и P на брой рам памет.Ако броя на видеокартите е по-голям от този на процесорите получава 15 % отстъпка от крайната сметка.Важат следните цени:
            //•	Видеокарта – 250 лв./ бр.
            //•	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //•	Рам памет – 10 % от цената на закупените видеокарти/ бр.
            //Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
            //Вход
            //Входът се състои от четири реда:
            //            1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            //2.Броят видеокарти - цяло число в интервала[0…100]
            //3.Броят процесори - цяло число в интервала[0…100]
            //4.Броят рам памет -цяло число в интервала[0…100]
            //Изход
            //На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
            //•	Ако бюджета е достатъчен:
            //"You have {остатъчен бюджет} leva left!"
            //•	Ако сумата надхвърля бюджета:
            //"Not enough money! You need {нужна сума} leva more!"
            //Резултатът да се форматира до втория знак след десетичната запетая.

        }
    }
}
