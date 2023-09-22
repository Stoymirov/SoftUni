using System;

namespace _04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double sum = 0;
            double sumr = 0;
            double sumo = 0;
            double sumy = 0;
            double sumw = 0;
            double sumb = 0;
            double sumothers = 0;
            for (int i = 0; i < input; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        sumr += 1;
                        sum += 5;
                        break;
                    case "orange":
                        sumo += 1;
                        sum += 10;
                        break;
                    case "yellow":
                        sumy += 1;
                        sum += 15;
                        break;
                    case "white":
                        sumw +=1;
                        sum += 20;
                        break;
                    case "black":
                        sum = Math.Floor(sum/2);
                        sumb++;
                        break;
                        default:
                        sumothers++;
                        break;
                }

            }
            
            Console.WriteLine($"Total points: {sum}");
            Console.WriteLine($"Red balls: {sumr}");
            Console.WriteLine($"Orange balls: {sumo}");
            Console.WriteLine($"Yellow balls: {sumy}");
            Console.WriteLine($"White balls: {sumw}");
            Console.WriteLine($"Other colors picked: {sumothers}");
            Console.WriteLine($"Divides from black balls: {sumb}");
        }
    }
}
