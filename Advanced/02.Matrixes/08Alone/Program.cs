using System;

namespace _08Alone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long[][] pascal= new long[number][];
            pascal[0] = new long[1] { 1 };

            for (int row = 1; row < number; row++)
            {
                pascal[row] = new long[row + 1];
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (col == 0 || col == pascal[row].Length - 1)
                    {
                        pascal[row][col] = 1;
                    }
                    else
                    {
                        pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                    }
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(" ",row));
            }
            //for (int row = 0; row < number; row++)
            //{
            //    for (int col = 0; col < pascal[row].Length; col++)
            //    {
            //        Console.Write(pascal[row][col] +" ");
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
