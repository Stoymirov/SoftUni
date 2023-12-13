
int size = int.Parse(Console.ReadLine());
string[] directions = Console.ReadLine().Split();


int rowc = 0;
int colc = 0;
int coalSumCollected = 0;
int coalSumTotal = 0;
string[,] matrix = new string[size, size];
for (int row = 0; row < size; row++)
{
    string[] input = Console.ReadLine().Split().ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = input[col];
        if (matrix[row, col] == "s")
        {
            rowc = row;
            colc = col;
        }

        if (matrix[row, col] == "c")
        {
            coalSumTotal++;
        }
    }
}

foreach (string direction in directions)
{
    
    switch (direction)
    {
        case "up":
            if (rowc - 1 >= 0)
            {
                rowc--;
                if (Checking(matrix, rowc, colc, ref coalSumCollected)) return;
            }
            break;
        case "down":
            if (rowc + 1 < size)
            {
                rowc++;
                if (Checking(matrix, rowc, colc, ref coalSumCollected)) return;
            }
            break;
        case "right":
            if (colc + 1 < size)
            {
                colc++;
                if (Checking(matrix, rowc, colc, ref coalSumCollected)) return;
                ;
            }
            break;
        case "left":
            if (colc - 1 >= 0)
            {
                colc--;
                if (Checking(matrix, rowc, colc, ref coalSumCollected)) return;
                
            }
            break;
    }
}
if(coalSumTotal-coalSumCollected!=0)
Console.WriteLine($"{coalSumTotal-coalSumCollected} coals left. ({rowc}, {colc})");
else Console.WriteLine($"You collected all coals! ({rowc}, {colc})");

bool Checking(string[,] strings, int i, int colc1, ref int coalSumCollected1)
{
    if (strings[i, colc1] == "e")
    {
        Console.WriteLine($"Game over! ({i}, {colc1})");
        return true;
    }

    if (strings[i, colc1] == "c")
    {
        coalSumCollected1++;
        strings[i, colc1] = "*";
        if (coalSumTotal == coalSumCollected)
        {
            Console.WriteLine($"You collected all coals! ({rowc}, {colc})");
            return true;
        }
    }

    return false;
}