int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

MatrixFillIn(rows, matrix);


MatrixMultiplier(rows, matrix);


AddSubstract(matrix);


Print(rows, matrix);








void MatrixMultiplier(int rows, int[][] ints)
{
    for (int row = 0; row < rows - 1; row++)
    {
        if (ints[row].Length == ints[row + 1].Length)
        {

            for (int row2 = row; row2 <= row + 1; row2++)
            {
                for (int col = 0; col < ints[row2].Length; col++)
                {
                    ints[row2][col] *= 2;
                }
            }
        }
        else
        {
            for (int row3 = row; row3 <= row + 1; row3++)
            {
                for (int col = 0; col < ints[row3].Length; col++)
                {
                    ints[row3][col] /= 2;
                }
            }
        }
    }
}

void MatrixFillIn(int rows1, int[][] matrix1)
{
    for (int row = 0; row < rows1; row++)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        matrix1[row] = new int[input.Length];
        for (int col = 0; col < matrix1[row].Length; col++)
        {
            matrix1[row][col] = input[col];
        }
    }
}

void AddSubstract(int[][] ints1)
{
    string s;
    while ((s = Console.ReadLine().ToLower()) != "end")
    {
        string[] array = s.Split();
        string operation = array[0];
        int row = int.Parse(array[1]);
        int col = int.Parse(array[2]);
        int value = int.Parse(array[3]);
        if (row >= 0 && col >= 0 && row <= ints1.GetLength(0))
        {
            if (col <= ints1[row].Length)
            {

                switch (operation)
                {
                    case "add":
                        if (ints1.GetLength(0) > row && ints1[row].Length > col)
                        {
                            ints1[row][col] += value;
                        }

                        break;
                    case "subtract":
                        if (ints1.GetLength(0) > row && ints1[row].Length > col)
                        {
                            ints1[row][col] -= value;
                        }

                        break;
                }
            }
        }
    }
}

void Print(int i1, int[][] matrix2)
{
    for (int row = 0; row < i1; row++)
    {
        for (int col = 0; col < matrix2[row].Length; col++)
        {
            Console.Write(matrix2[row][col] + " ");
        }

        Console.WriteLine();
    }
}