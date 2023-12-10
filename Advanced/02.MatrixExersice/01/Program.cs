int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size,size];
int sumOfGlaven = 0;
int sumOfVtorostepenen = 0;

for (int row = 0; row < size; row++)
{
    int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < size;col ++)
    {
        matrix[row,col] = input[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (row == col)
        {
            sumOfGlaven += matrix[row, col];
        }

        if ( col == size - 1 - row)
        {
            sumOfVtorostepenen += matrix[row, col];
        }
    }
}

Console.WriteLine(Math.Abs(sumOfGlaven-sumOfVtorostepenen));