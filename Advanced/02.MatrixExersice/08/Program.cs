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

int removedKnights = 0;
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] == 'K')
        {
            int currentHighestValue = 0;

            (int, int)[] possibleMoves = {
                (row + 2, col + 1), (row + 2, col - 1), (row + 1, col + 2), (row + 1, col - 2),
                (row - 2, col + 1), (row - 2, col - 1), (row - 1, col + 2), (row - 1, col - 2)
            };

            foreach ((int, int) move in possibleMoves)
            {
                int moveRow = move.Item1;
                int moveCol = move.Item2;

                if (moveRow >= 0 && moveRow < size && moveCol >= 0 && moveCol < size && matrix[moveRow, moveCol] == 'K')
                {
                    currentHighestValue++;
                }
            }

            if (currentHighestValue > 0)
            {
                matrix[row, col] = 'O';
                removedKnights++;
            }
        }
    }
}

Console.WriteLine(removedKnights);