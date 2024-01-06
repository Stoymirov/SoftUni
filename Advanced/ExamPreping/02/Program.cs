int n = int.Parse(Console.ReadLine());

int x = 0;
int y = 0;

int fish = 0;

string[,] matrix = new string[n,n];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        if (input[j].ToString() == "S")
        {
            x = i;
            y = j;
        }
        matrix[i,j] = input[j].ToString();
    }
}

string command = "";
while ((command = Console.ReadLine()) != "collect the nets")
{
    matrix[x, y] = "-";
    switch (command)
    {
        case "down":
            x++;
            break;
        case "up":
            x--;
            break;
        case "left":
            y--;
            break;
        case "right":
            y++;
            break;
    }

    if (x >= n) x = 0; if (y >= n) y = 0; if (y < 0) y = n - 1; if (x < 0) x = n - 1;

    if (matrix[x, y] == "W")
    {
        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{x},{y}]");
        Environment.Exit(0);
    }

    if (matrix[x, y] != "-")
    {
        fish += int.Parse(matrix[x, y]);
        
    }
}

if (fish < 20)
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20-fish} tons of fish more.");
}
if (fish >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}

if (fish > 0)
{
    Console.WriteLine($"Amount of fish caught: {fish} tons.");
}
//print the matrix
matrix[x, y] = "S";
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i,j]);
    }

    Console.WriteLine();
}