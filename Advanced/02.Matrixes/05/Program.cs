using System;
using System.Linq;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] inputNumbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            (int, int) maxSquareCordiantes = (0, 0);
            int maxSquareSum = Int32.MinValue;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    
                    int currentSum = matrix[row, col] +
                                     matrix[row + 1, col] +
                                     matrix[row + 1, col + 1] +
                                     matrix[row, col + 1];
                    if (currentSum > maxSquareSum)
                    {
                        maxSquareSum = currentSum;
                        maxSquareCordiantes = (row, col);
                    }
                }
            }

            Console.Write(matrix[maxSquareCordiantes.Item1,maxSquareCordiantes.Item2]+" ");
            Console.WriteLine(matrix[maxSquareCordiantes.Item1,maxSquareCordiantes.Item2+1]);
            Console.Write(matrix[maxSquareCordiantes.Item1+1, maxSquareCordiantes.Item2] + " ");
            Console.WriteLine(matrix[maxSquareCordiantes.Item1+1, maxSquareCordiantes.Item2 + 1]);
            Console.WriteLine(maxSquareSum);
        }

    }
}

