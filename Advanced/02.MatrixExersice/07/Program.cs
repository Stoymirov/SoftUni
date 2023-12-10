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
while (highestValueKnight != 0)
{
int highestValueKnight =0;

(int, int) highestValueKnightCor = (0,0);

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row, col] == 'O')
            {
                continue;
            }
            else
            {
                int currentHighestValue = 0;
                if (matrix[row, col] == 'K')
                {
                    (int, int) index1 = (row + 2, col + 1);
                    (int, int) index2 = (row + 2, col - 1);
                    (int, int) index3 = (row + 1, col + 2);
                    (int, int) index4 = (row + 1, col - 2);
                    (int, int) index5 = (row - 2, col + 1);
                    (int, int) index6 = (row - 2, col - 1);
                    (int, int) index7 = (row - 1, col + 2);
                    (int, int) index8 = (row - 1, col - 2);
                    if (index1.Item1 >= 0 && index1.Item1 < size && index1.Item2 >= 0 && index1.Item2 < size)
                    {
                        if (matrix[index1.Item1, index1.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index2.Item1 >= 0 && index2.Item1 < size && index2.Item2 >= 0 && index2.Item2 < size)
                    {
                        if (matrix[index2.Item1, index2.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index3.Item1 >= 0 && index3.Item1 < size && index3.Item2 >= 0 && index3.Item2 < size)
                    {
                        if (matrix[index3.Item1, index3.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index4.Item1 >= 0 && index4.Item1 < size && index4.Item2 >= 0 && index4.Item2 < size)
                    {
                        if (matrix[index4.Item1, index4.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index5.Item1 >= 0 && index5.Item1 < size && index5.Item2 >= 0 && index5.Item2 < size)
                    {
                        if (matrix[index5.Item1, index5.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index6.Item1 >= 0 && index6.Item1 < size && index6.Item2 >= 0 && index6.Item2 < size)
                    {
                        if (matrix[index6.Item1, index6.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }
                    if (index7.Item1 >= 0 && index7.Item1 < size && index7.Item2 >= 0 && index7.Item2 < size)
                    {
                        if (matrix[index7.Item1, index7.Item2] == 'K')
                        {
                            currentHighestValue++;
                        }
                    }

                    if (index8.Item1 >= 0 && index8.Item1 < size && index8.Item2 >= 0 && index8.Item2 < size)
                    {
                        if (matrix[index8.Item1, index8.Item2] == 'K')
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

    if (highestValueKnight != 0)
    {
        matrix[highestValueKnightCor.Item1, highestValueKnightCor.Item2] = 'O';
        removedKnighes++;
    highestValueKnight = Int32.MinValue;
    }
    else
    {
        break;
    }


}

Console.WriteLine(removedKnighes);