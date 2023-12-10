int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

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
string command = "";
while ((command = Console.ReadLine().ToLower()) != "end")
{
    if (IsValidCommand(command, rows, cols))
    {
        string[] array = command.Split();
        string element1 = matrix[int.Parse(array[1]), int.Parse(array[2])];
        string element2 = matrix[int.Parse(array[3]), int.Parse(array[4])];
        matrix[int.Parse(array[1]), int.Parse(array[2])] = element2;
        matrix[int.Parse(array[3]), int.Parse(array[4])] = element1;

        NewFunction(matrix);

    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

}

static bool IsValidCommand(string command, int rows, int cols)
{
    string[] array = command.Split().ToArray();
    bool validCommand = array[0] == "swap";
    bool validLength = array.Length == 5;
    bool validIndexes = false;

    if (validLength && validCommand)
    {
        int x1 = int.Parse(array[1]);
        int y1 = int.Parse(array[2]);
        int x2 = int.Parse(array[3]);
        int y2 = int.Parse(array[4]);
        validIndexes =
        x1 < rows && x1 >= 0
       && x2 < rows && x2 >= 0
       && y1 < cols && y1 >= 0
       && y2 < cols && y2 >= 0;
    }

    
    return validIndexes && validCommand && validLength;

}

void NewFunction(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}