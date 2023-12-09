int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n,n];
for (int row = 0; row < n; row++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row,col] = input[col];
    }
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum); //first diagonal
int sum2 = 0;
for (int i = 0; i < n; i++)
{
    sum2 +=(matrix[i,n-i-1]);
}

Console.WriteLine(sum2);//other diagonal