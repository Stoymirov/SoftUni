Console.WriteLine("How many rows?");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("How many cols?");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    int[] rowsValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rowsValue[j];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }

    Console.WriteLine();
}