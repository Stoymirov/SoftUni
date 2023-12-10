int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

string snake = Console.ReadLine();
int rows = input[0];
int cols = input[1];

char[,] matrix = new char[rows, cols];


int snakeIndex = 0;
for (int row = 0; row < rows; row += 2)
{

    for (int col = 0; col < cols; col += 1)
    {
        matrix[row, col] = snake[snakeIndex];
        snakeIndex = (snakeIndex + 1) % snake.Length;

    }

    if (row + 1 < rows)
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row + 1, col] = snake[snakeIndex];
            snakeIndex = (snakeIndex + 1) % snake.Length;

        }
    }


}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row,col]);
    }

    Console.WriteLine();
}