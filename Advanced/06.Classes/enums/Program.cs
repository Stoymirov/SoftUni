﻿using enums;

int row = 0;
int col = 0;
Direction direction = Direction.Down;
while (true)
{
    Console.SetCursorPosition(col, row);
    Console.WriteLine("@");

    if (direction == Direction.Down)
    {
        row++;
    }

    if (direction == Direction.Up)
    {
        row--;
    }

    if (direction == Direction.Left)
    {
        col--;
    }

    if (direction == Direction.Right)
    {
        col++;
    }

    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.RightArrow)
        {
            direction = Direction.Right;
        }
        if (key.Key == ConsoleKey.LeftArrow)
        {
            direction = Direction.Left;
        }
        if (key.Key == ConsoleKey.UpArrow)
        {
            direction = Direction.Up;
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            direction = Direction.Down;
        }
    }
    Thread.Sleep(100);
    Console.Clear();
}