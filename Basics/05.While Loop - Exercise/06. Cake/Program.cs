using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = width * length;
            string stoper = Console.ReadLine();
            int sumOfArea = 0;
            bool b = false;
            while (stoper != "STOP")
            {
                int PieceNumber = int.Parse(stoper);
                sumOfArea += PieceNumber;
                if (sumOfArea >= area)
                {
                    b = true;
                    break;
                }
                stoper = Console.ReadLine();
            }
            if (b)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(area - sumOfArea)} pieces more.");
            }
            else Console.WriteLine($"{area - sumOfArea} pieces are left.");
        }
    }
}
