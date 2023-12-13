//if a bomb cell has a value of 0 do not explode it!!
int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
    }
}
int[] coordinates = Console.ReadLine().Split(new[] { ',', ' ' }).Select(int.Parse).ToArray();

int[] rowCoordinates = new int[coordinates.Length / 2]; 
int[] colCoordinates = new int[coordinates.Length / 2];
for (int i = 0; i < coordinates.Length; i+=2)
{
    rowCoordinates[i/2] = coordinates[i];
    colCoordinates[i / 2] = coordinates[i + 1];
}
int[] rowc = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
int[] colc = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
for (int j = 0; j < rowCoordinates.Length; j++)
{
    int bombRowIndex = rowCoordinates[j];
    int bombColIndex = colCoordinates[j];

    if (matrix[bombRowIndex, bombColIndex] > 0)
    {
        int bombValue = matrix[bombRowIndex, bombColIndex];
        matrix[bombRowIndex, bombColIndex] = 0;
        for (int i = 0; i < 8; i++)
        {
            int rowToCheckIndex = bombRowIndex + rowc[i];
            int colToCheckIndex = bombColIndex + colc[i];
            if (rowToCheckIndex >= 0 && colToCheckIndex >= 0 && rowToCheckIndex < size && colToCheckIndex < size && matrix[rowToCheckIndex, colToCheckIndex] > 0)
            {
                matrix[rowToCheckIndex, colToCheckIndex]-=bombValue;
            }
        }
    }


}

int aliveCells = 0;
int value = 0;
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] > 0)
        {
            aliveCells++;
            value += matrix[row, col];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {value}");
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}