using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            bool headTrick = false;
            int maxGoals = int.MinValue;
            string maxName = "";
            while (name != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals >= 3)
                {
                    headTrick = true;
                }
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                   maxName = name;
                }
                if (goals >= 10)
                {
                    headTrick = true;
                    break;
                }
               

                name = Console.ReadLine();
            }
            Console.WriteLine($"{maxName} is the best player!");
            if (headTrick)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else Console.WriteLine($"He has scored {maxGoals} goals.");

        }
    }
}
