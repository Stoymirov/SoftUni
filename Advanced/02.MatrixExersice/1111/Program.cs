int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];
int playerIndexRow = 0;
int playerIndexCol = 0;

for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = (input[col]);
        if (matrix[row, col] == 'P')
        {
            playerIndexRow = row;
            playerIndexCol = col;
        }
    }
}
string directions = Console.ReadLine();

foreach (var direction in directions)
{
    int oldPlayerRow = playerIndexRow;
    int oldPlayerCol = playerIndexCol;
    switch(direction)
    {
        case 'L':
            playerIndexCol--;
            break;
        case 'R':
            playerIndexCol++;
            break;
        case 'U':
            playerIndexRow--;
            break;
        case 'D':
            playerIndexRow++;

            break;

    }

    matrix = SpreadBunnies();
    if (playerIndexRow < 0
        || playerIndexRow >= rows
        || playerIndexCol >= cols
        ||playerIndexCol<0)
    {
        PrintResult(oldPlayerRow,oldPlayerCol,"won");
        break;
    }

    if (matrix[playerIndexRow, playerIndexCol] == 'B')
    {
        PrintResult(playerIndexRow,playerIndexCol,"dead");
        break;
    }
}


char[,] SpreadBunnies()
{
    char[,] newMatrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            newMatrix[row,col] = matrix[row, col];
        }
    }

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row, col] == 'B')
            {
                if (row > 0)
                {
                    newMatrix[row - 1, col] = 'B';
                }

                if (row < rows - 1)
                {
                    newMatrix[row + 1, col] = 'B';
                }

                if (col > 0)
                {
                    newMatrix[row, col - 1] = 'B';
                }

                if (col < cols - 1)
                {
                    newMatrix[row, col + 1] = 'B';
                }
            }
        }
    }
    return newMatrix;
}
void PrintResult(int playerRow, int playerCol, string result)
{

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row, col] == 'P')
            {
                Console.Write('.');
                continue;
            }

            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }

    Console.WriteLine($"{result}: {playerRow} {playerCol}");
}
