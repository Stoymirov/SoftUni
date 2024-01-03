﻿using System.Threading.Channels;

namespace TheGambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] board = new string[size, size];

            int currRow = -1;
            int currCol = -1;

            int amount = 100;
            bool isEverythingLost = false;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                string newRow = Console.ReadLine();
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (newRow[j].ToString() == "G")
                    {
                        currRow = i;
                        currCol = j;
                        board[i, j] = "-";
                        continue;
                    }

                    board[i, j] = newRow[j].ToString();
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (GamblerLeftTheBoard(size, currRow, currCol, command))
                {
                    isEverythingLost = true;
                    break; ;
                }

                if (command == "left")
                {
                    currCol--;
                }
                if (command == "right")
                {
                    currCol++;
                }
                if (command == "up")
                {
                    currRow--;
                }
                if (command == "down")
                {
                    currRow++;
                }

                if (board[currRow, currCol] == "W")
                {
                    amount += 100;
                }
                if (board[currRow, currCol] == "P")
                {
                    amount -= 200;
                }
                if (board[currRow, currCol] == "J")
                {
                    amount += 100000;
                    Console.WriteLine("You win the Jackpot!");
                    break;
                }

                if (amount <= 0)
                {
                    isEverythingLost = true;
                    break;
                }
                board[currRow, currCol] = "-";
            }

            if (isEverythingLost)
            {
                Console.WriteLine("Game over! You lost everything!");
                Environment.Exit(0);
            }

            board[currRow, currCol] = "G";

            Console.WriteLine($"End of the game. Total amount: {amount}$");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static bool GamblerLeftTheBoard(int size, int currRow, int currCol, string? command)
        {
            if (command == "left" && currCol == 0)
            {
                return true;
            }
            if (command == "right" && currCol == size - 1)
            {
                return true;
            }
            if (command == "up" && currRow == 0)
            {
                return true;
            }
            if (command == "down" && currRow == size - 1)
            {
                return true;
            }

            return false;
        }
    }
}