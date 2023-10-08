int number = int.Parse(Console.ReadLine());
void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
        
    }
    Console.WriteLine();
}
for (int i = 1; i <= number; i++)
{
    PrintLine(1, number);
}
for (int i = number - 1; i >= 1; i--)
{
    PrintLine(1, number);
}

    