using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascal = new long[rows][];

            pascal[0] = new long[1] { 1 };
            for (int row = 1; row < rows; row++)
            {
                pascal[row] = new long[row + 1];
                
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (col == 0 || col == pascal[row-1].Length)
                    {
                        
                        pascal[row][col] = 1;
                    }
                    else
                    {
                        pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    Console.Write(pascal[i][j]+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
