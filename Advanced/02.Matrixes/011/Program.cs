int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];
int sum = 0;
for (int row = 0; row < rows; row++)
{
    int[] rowValue = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowValue[col];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        sum += matrix[i, j];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);
