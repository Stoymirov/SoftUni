using System;

namespace _05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counterOfDays = 1;
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "Yes")
            {
                counterOfDays++;
            }
            
            int metersTotal = 0;
            bool done = false;
            while (YesOrNo != "END" && counterOfDays!=6)
            {
                int meters = int.Parse(Console.ReadLine());
                metersTotal += meters;
                if (metersTotal >= 3484)
                {
                    done = true;
                    break;
                }
                YesOrNo = Console.ReadLine();
                if (YesOrNo == "Yes")
                {
                    counterOfDays++;
                }
                
            }
            if (done)
            {
                Console.WriteLine($"Goal reached for {counterOfDays} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(5364 + metersTotal);
            }
        }
    }
}
