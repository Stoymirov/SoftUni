using System;

namespace _05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            bool headTrick = false;
            int maxGoals = int.MinValue;
            while (name != "END")
            {
               int goals = int.Parse(Console.ReadLine());
               if (goals >= 3)
                {
                    headTrick = true;
                }
               if (goals >=10)
                {
                    headTrick = true;
                    break;
                }
               if (goals > maxGoals)
                {
                    maxGoals = goals;
                }
                
                name = Console.ReadLine();
            }
            Console.WriteLine($"{name} is the best player!");
            if (headTrick) 
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else Console.WriteLine($"He has scored {maxGoals} goals.");
        }
        
    }
}
