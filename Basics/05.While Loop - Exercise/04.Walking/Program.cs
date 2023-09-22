using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int threshhold = 10000;
            int sumOfSteps = 0;
            string goingHome = Console.ReadLine();
            bool isTrue = false;
            while (goingHome != "Going home")
            {
                int stepsInput = int.Parse(goingHome);
                sumOfSteps += stepsInput;

                if (sumOfSteps >= threshhold)
                {isTrue = true;
                    break;
                }
                        goingHome = Console.ReadLine();
            }
            if (isTrue)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumOfSteps - threshhold} steps over the goal!");
            }
            else
            {
                int stepsHome = int.Parse(Console.ReadLine());
                sumOfSteps += stepsHome;
                if (sumOfSteps >= threshhold)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - threshhold} steps over the goal!");
                }    
                else
                Console.WriteLine($"{Math.Abs(threshhold - sumOfSteps)} more steps to reach goal.");
            }
            
        }
    }
}
