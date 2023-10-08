int number = int.Parse(Console.ReadLine());
SignOfNumber(number);
static void SignOfNumber(int number)
{
    if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else Console.WriteLine($"The number {number} is negative.");
}