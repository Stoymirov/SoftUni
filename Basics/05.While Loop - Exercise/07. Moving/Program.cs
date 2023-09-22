using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            bool b = false;

            int boxAmount = width * height * length;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxAmount -= boxes;
                if (boxAmount < 0)
                {
                    b = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (b)
            {
                Console.WriteLine($"No more free space! You need {-1 *  boxAmount} Cubic meters more.");
            }
            else Console.WriteLine($"{boxAmount} Cubic meters left.");
        }
    }
}
