using System.ComponentModel.Design;

int n = int.Parse(Console.ReadLine());
int money = 100;
(int, int) current = default;
string[,] matrix = new string[n, n];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        if (input[j].ToString() == "G")
            current = (i, j);
        matrix[i, j] = input[j].ToString();
    }
}

string command = default;
while ((command = Console.ReadLine()) != "end")
{
    matrix[current.Item1, current.Item2] = "-";

    switch (command)
    {
        case "left":
            current.Item2--;
            break;
        case "right":
            current.Item2++;
            break;
        case "up":
            current.Item1--;
            break;
        case "down":
            current.Item1++;
            break;
    }


    if (current.Item1 < 0 || current.Item1 > n - 1 || current.Item2 < 0 || current.Item2 > n - 1)
    {
        Console.WriteLine("Game over! You lost everything!");
        Environment.Exit(0);

    }
    else if (matrix[current.Item1, current.Item2] == "W")
    {
        money += 100;
    }
    else if (matrix[current.Item1, current.Item2] == "P")
    {
        money -= 200;
        if (money <= 0)
        {
            Console.WriteLine("Game over! You lost everything!");
            Environment.Exit(0);

        }
    }
    else if (matrix[current.Item1, current.Item2] == "J")
    {
        money += 100000;

        Console.WriteLine("You win the Jackpot!");
        break;

    }
   
}




matrix[current.Item1, current.Item2] = "G";

Console.WriteLine($"End of the game. Total amount: {money}$");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}
