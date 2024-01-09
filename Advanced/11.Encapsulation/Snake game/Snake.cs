using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_game
{
    public class Snake
    {
        int Height = 20;
        private int Width = 30;

        private int[] X = new int[50];
        int[] Y = new int[50];

        private int fruitX;
        private int fruitY;

        private int parts = 3;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        private char key = 'W';

        Random random = new Random();

        public Snake()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            fruitX = random.Next(2, Width - 2);
            fruitY = random.Next(2, Height - 2);
        }
        public void WriteBoard()
        {
            Console.Clear();
            for (int i = 1; i < Width + 2; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine("-");

            }
            for (int i = 1; i < Width + 2; i++)
            {
                Console.SetCursorPosition(i, Height + 2);
                Console.WriteLine("-");

            }
            for (int i = 1; i < Height + 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
            }

            for (int i = 1; i < Height + 1; i++)
            {
                Console.SetCursorPosition(Width + 2, i);
                Console.WriteLine("|");
            }

        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }

        public void Logic()
        {
            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    parts++;
                    fruitX = random.Next(2, Width - 2);
                    fruitY = random.Next(2, Height - 2);
                }
            }

            for (int i = parts; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];

            }

            switch (key)
            {
                case 'w':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'a':
                    X[0]--;
                    break;
                case 'd':
                    X[0]++;
                    break;
            }

            for (int i = 0; i <= parts - 1; i++)
            {
                WritePoint(X[i], Y[i]);
            }
            WritePoint(fruitX, fruitY);
            Thread.Sleep(100);
        }
    }
}
