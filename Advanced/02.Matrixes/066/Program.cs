using System;
using System.Linq;
using System.Numerics;

namespace _066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = rowValues;
            }

            string command = "";
            while((command=Console.ReadLine().ToLower())!= "end")
            {
                string[] array = command.Split().ToArray();
                int row = int.Parse(array[1]);
                int col = int.Parse(array[2]);
                int value = int.Parse(array[3]);
                if (row < 0 || col < 0 || row >= rows || jaggedArray[row].Length <= col)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                switch(array[0])
                {
                    case "add":
                        jaggedArray[row][col] += value;
                       break;
                    case "subtract":
                        jaggedArray[row][col] -= value;

                        break;
                }
            }

            for (int row = 0;row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length;col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
