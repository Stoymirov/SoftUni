using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());

            if (input <= 100)
            {
                int bonus = 5;
                if (input % 2 == 0)
                {
                    int moreBonus = 1;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else if ( input % 10 == 5 )
                {
                    int moreBonus = 2;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(bonus + input);
                }

            }
            else if (input <= 1000)
            {
                double bonus = 0.2 * input;
                if (input % 2 == 0)
                {
                    int moreBonus = 1;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else if (input % 10 == 5)
                {
                    int moreBonus = 2;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(bonus + input);
                }

            }
            else if (input > 1000)
            {
                double bonus = 0.1 * input;
                if (input % 2 == 0)
                {
                    int moreBonus = 1;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else if (input % 10 == 5)
                {
                    int moreBonus = 2;
                    Console.WriteLine(bonus + moreBonus);
                    Console.WriteLine(input + bonus + moreBonus);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(bonus + input);
                }


            }
        }
    }
}
