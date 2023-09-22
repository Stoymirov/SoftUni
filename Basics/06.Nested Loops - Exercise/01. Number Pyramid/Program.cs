using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int currentNumber = 1;
            bool MoreRows = true;
            while (MoreRows)
            {
                for (int i = 0;i<row;i++)
                {
                    Console.Write($"{currentNumber} ");
                    if (currentNumber ==n)
                    {
                        MoreRows = false;
                        break;
                    }
                    currentNumber ++;
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
