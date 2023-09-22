using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            string sector = "";
            
            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;
            for (int i = 0; i < fans; i++)
            {
                sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        fansA++ ; break;
                    case "B":
                        fansB++;
                        break;
                    case "V":
                        fansV++;
                        break;
                    case "G":
                        fansG++;
                        break;
                }

            }
            //int totalFansTeam1 = fansA+fansB;
            //int totalFansTeam2 = fansC + fansD;
            double perantageA = (fansA * 100.0) / fans;
            double perantageB = (fansB * 100.0) / fans;
            double perantageV = (fansV * 100.0) / fans;
            double perantageG = (fansG * 100.0) / fans;
            double fansInStadPercentage = (fans * 100.0) / capacity;
            Console.WriteLine($"{perantageA:f2}%");
            Console.WriteLine($"{perantageB:f2}%");
            Console.WriteLine($"{perantageV:f2}%");
            Console.WriteLine($"{perantageG:f2}%");
            Console.WriteLine($"{fansInStadPercentage:f2}%");

        }
    }
}
