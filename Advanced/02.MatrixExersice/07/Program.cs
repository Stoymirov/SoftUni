using System.Numerics;

int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];
for (int row = 0; row < size; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
    }
}
int removedKnighes = 0;
while (true)
{
    int highestValueKnight = 0;

    (int, int) highestValueKnightCor = (0, 0);

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row, col] == 'K')
            {
                int currentHighestValue = 0;
                int[] rowC = new int[] { 2, 2, 1, 1, -2, -2, -1, -1 };
                int[] colC = new int[] { 1, -1, 2, -2, 1, -1, 2, -2 };
                for (int i = 0; i < 8; i++)
                {
                    int coordsRow = row + rowC[i];
                    int coordsCol = col + colC[i];
                    if (coordsRow >= 0 && coordsCol >= 0 && coordsRow < size && coordsCol < size)
                    {
                        if (matrix[coordsRow, coordsCol] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                }

                if (currentHighestValue > highestValueKnight)
                {
                    highestValueKnight = currentHighestValue;
                    highestValueKnightCor = (row, col);
                }
            }
        }
    }

    if (highestValueKnight > 0)
    {
        matrix[highestValueKnightCor.Item1, highestValueKnightCor.Item2] = 'O';
        removedKnighes++;
    }
    else
    {
        break;
    }


}

Console.WriteLine(removedKnighes);