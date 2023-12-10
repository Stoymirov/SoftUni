using System.Numerics;

int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(n=>int.Parse(n)).ToArray();

int rows = input[0];
int cols = input[1];
string[,] matrix = new string[rows, cols];
for (int row = 0; row < rows; row++)
{
    string[] input2 = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input2[col];
    }
}

int sum = 0;
for (int row = 0; row < rows-1; row++)
{
    for (int col = 0; col < cols-1; col++)
    {
        if( matrix[row, col] == matrix[row,col+1] &&
            matrix[row, col] == matrix[row + 1, col]&&
            matrix[row, col] == matrix[row+1,col+1])
        {
            sum++;
        }
    }
}

Console.WriteLine(sum);