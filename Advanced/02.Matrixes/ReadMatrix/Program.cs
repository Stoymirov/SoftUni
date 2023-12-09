Console.WriteLine("How many rows?");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("How many cols?");
int cols = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        int output = 0;
        Console.WriteLine($"matrix[{i}, {j}]=?");
        bool my = int.TryParse(Console.ReadLine(), out int number);
        if (my == true)
        {
            matrix[i, j] = number;
        }
        else
        {
            while (!my)
            {
                Console.WriteLine("Write a valid number!");
                my = int.TryParse(Console.ReadLine(), out number);
            }
            matrix[i, j] = number;
        }
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i,j] + " ");
    }

    Console.WriteLine();
}