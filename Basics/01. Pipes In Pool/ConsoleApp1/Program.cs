using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sqM = int.Parse(Console.ReadLine());
           double grapesPerSqM = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double totalGrapes = sqM * grapesPerSqM;
            double GrapesForWine = totalGrapes * 0.4;
            double litersWine = GrapesForWine * 0.4;
            if (litersWine >= wineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWine - wineNeeded)} liters left -> {Math.Ceiling((litersWine - wineNeeded) / workers)} liters per person.");
                
            }
            else if (wineNeeded > litersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - litersWine)} liters wine needed.");
            }
        }
    }
}
