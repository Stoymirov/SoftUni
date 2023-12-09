int rows = 3;
int cols = 5;

int[,] matrix = new int[rows,cols];
int count = 1;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = count++;
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] < 10)
        {
            Console.Write(" "+ matrix[row,col]+ " ");
        }
        else
    Console.Write(matrix[row,col] + " ");
    }

    Console.WriteLine();
}

