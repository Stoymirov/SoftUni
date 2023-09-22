using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTurnaments= int.Parse(Console.ReadLine());
            int currentPoints = int.Parse(Console.ReadLine());
            int sum = 0;
            int wonT = 0;
            for (int i = 0; i < numberOfTurnaments; i++)
            {
                string type = Console.ReadLine();
                switch (type)
                {
                    case "W":
                        sum += 2000;
                        wonT++;
                        break;
                    case "SF":
                        sum += 720;
                        break;
                    case "F":
                        sum += 1200;
                        break;
                }
            }
            int finalPoint = sum + currentPoints;
            double avarage = sum / numberOfTurnaments;
            double wonTInProcantage = wonT / (double)numberOfTurnaments * 100;
            Console.WriteLine($"Final points: {finalPoint}");
            Console.WriteLine($"Average points: {avarage}");
            Console.WriteLine($"{wonTInProcantage:f2}%");
        }
    }
}
