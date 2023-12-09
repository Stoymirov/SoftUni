int[] matrixSizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = matrixSizes[0];
int cols = matrixSizes[1];
int[] array = new int[cols];
int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = input[j];
    }
}
for (int col = 0; col < cols; col++)
{
    int sum = 0;
    int currentColSum = 0;
    for (int row = 0; row < rows; row++)
    {

       
        sum += matrix[row, col];
    }

    Console.WriteLine(sum);

}
