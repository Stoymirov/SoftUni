using System;
using System.Linq;

namespace _05.Modified
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[] sizeOfSquare = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsIn = sizeOfSquare[0];
            int colsIn = sizeOfSquare[1];

            int[,] matrix = new int[rows, cols];
            (int, int) maxSquareCoordianates = (0, 0);
            int maxSquareSum = Int32.MinValue;
            for (int row = 0; row < rows; row++)
            {
                int[] input1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input1[col];
                }
            }

            for (int row = 0; row <= rows - rowsIn; row++)
            {
                for (int col = 0; col <= cols - colsIn; col++)
                {
                    int sum = 0;
                    for (int rowSummer = row; rowSummer < row + rowsIn; rowSummer++)
                    {
                        for (int colSummer = col; colSummer < col + colsIn; colSummer++)
                        {
                            sum += matrix[rowSummer,colSummer];
                        }
                    }

                    if (sum > maxSquareSum)
                    {
                        maxSquareCoordianates = (row, col);
                        maxSquareSum = sum;
                    }
                }
            }

            for (int i = 0; i < rowsIn; i++)
            {
                for (int j = 0; j < colsIn; j++)
                {
                    Console.Write(matrix[maxSquareCoordianates.Item1+i,maxSquareCoordianates.Item2+j] +" ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSquareSum);
        }
    }
}

