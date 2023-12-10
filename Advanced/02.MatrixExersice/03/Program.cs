int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];
int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input2[col];
    }
}

(int, int) index = (0, 0);
int maxSum = Int32.MinValue;
for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                currentSum += matrix[row + i, col + j];
            }
        }
        if (currentSum > maxSum)
        {
            index.Item1 = row;
            index.Item2 = col;
            maxSum = currentSum;
        }
    }

}

Console.WriteLine($"Sum = {maxSum}");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[index.Item1 + i, index.Item2 + j] + " ");
    }

    Console.WriteLine();
}