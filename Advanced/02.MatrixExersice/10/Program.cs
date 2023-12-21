using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        var rows = Input(out var cols, out var matrix, out var playerIndexRow, out var playerIndexCol);

        bool dead = false;
        string commands = Console.ReadLine();
        foreach (char movement in commands)
        {
            if (Movement(movement, matrix, rows, cols, ref playerIndexRow, ref playerIndexCol))
            {
                dead = true;
            }

            bool catcher = BunnyMovement(rows, cols, matrix, playerIndexRow, playerIndexCol);
            ExchangeZ(rows, cols, matrix);

            if (dead == true)
                return;
            if (catcher == true)
            {
                ExchangeZ(rows, cols, matrix);
                MatrixPrint(matrix, rows, cols);
                Console.WriteLine($"dead: {playerIndexRow} {playerIndexCol}");
                return;
            };
        }

    }

    private static int Input(out int cols, out char[,] matrix, out int playerIndexRow, out int playerIndexCol)
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = size[0];
        cols = size[1];

        matrix = new char[rows, cols];
        playerIndexRow = 0;
        playerIndexCol = 0;

        for (int row = 0; row < rows; row++)
        {
            string input = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = (input[col]);
                if (matrix[row, col] == 'P')
                {
                    playerIndexRow = row;
                    playerIndexCol = col;
                }
            }
        }

        return rows;
    }

    private static void ExchangeZ(int rows, int cols, char[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == 'Z')
                {
                    matrix[row, col] = 'B';
                }

                if (matrix[row, col] == 'P')
                {
                    matrix[row, col] = '.';
                }
            }
        }
    }

    private static bool BunnyMovement(int rows, int cols, char[,] matrix, int playerIndexRow, int playerIndexCol)
    {
        bool to = false;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row, col] == 'B')
                {
                    int[] rowDir = { -1, 0, 0, 1 };
                    int[] colDir = { 0, -1, 1, 0 };
                    for (int i = 0; i < 4; i++) //check for player
                    {

                        if (row + rowDir[i] >= 0 && row + rowDir[i] < rows && col + colDir[i] >= 0 && col + colDir[i] < cols)
                        {
                            if (matrix[row + rowDir[i], col + colDir[i]] == 'P')
                            {
                                matrix[rowDir[i] + row, colDir[i] + col] = 'Z';

                                to = true;
                            }
                            else
                            {
                                if (matrix[row + rowDir[i], col + colDir[i]] != 'B')
                                    matrix[row + rowDir[i], col + colDir[i]] = 'Z';
                            }
                        }
                    }
                }
            }
        }

        return to;
    }

    static void MatrixPrint(char[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
    static bool Movement(char c, char[,] matrix, int rows, int cols, ref int playerIndexRow, ref int playerIndexCol)
    {
        int[] dRow = { -1, 0, 1, 0 };
        int[] dCol = { 0, -1, 0, 1 };
        string[] dir = { "U", "L", "D", "R" };

        for (int i = 0; i < dir.Length; i++)
        {
            if (c == dir[i][0])
            {
                int newRowIndex = playerIndexRow + dRow[i];
                int newColIndex = playerIndexCol + dCol[i];
                if (newRowIndex < 0 || newColIndex < 0 || newColIndex >= cols || newRowIndex >= rows)
                {
                    BunnyMovement(rows, cols, matrix, playerIndexRow, playerIndexCol);
                    ExchangeZ(rows, cols, matrix);
                    MatrixPrint(matrix, rows, cols);
                    Console.WriteLine($"won: {playerIndexRow} {playerIndexCol}");

                    return true;
                }

                if (matrix[newRowIndex, newColIndex] == 'B')
                {
                    BunnyMovement(rows, cols, matrix, playerIndexRow, playerIndexCol);
                    ExchangeZ(rows, cols, matrix);
                    MatrixPrint(matrix, rows, cols);
                    Console.WriteLine($"dead: {newRowIndex} {newColIndex}");
                    return true;
                }

                matrix[playerIndexRow, playerIndexCol] = '.';

                playerIndexRow = newRowIndex;
                playerIndexCol = newColIndex;
                matrix[playerIndexRow, playerIndexCol] = 'P';
                return false;
            }

        }

        return false;
    }

}