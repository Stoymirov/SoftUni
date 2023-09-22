using System;

namespace _02.Bonus_Score_RightWay_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.input
            int input = int.Parse(Console.ReadLine());


            double bonus = 0;

            //2.bonus
            if (input <= 100)
            {
                bonus = 5;
            }
            else if (input <= 1000)
            {
                bonus = 0.2 * input;
            }
            else if (input > 1000)
            {
                bonus = 0.1 * input;
            }
            //3.morebonus
            if (input % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (input % 10 ==5) 
            {
                bonus = bonus + 2;
            }
            //4.consolewrite
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + input);

        }
    }
}
