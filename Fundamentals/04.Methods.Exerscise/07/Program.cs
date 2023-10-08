int number = int.Parse(Console.ReadLine());

PrintTheNumber(number);
static void PrintTheNumber(int number)
{
    int[] arr = new int[number];
    for (int i = 0; i <arr.Length; i++)
    {
        arr[i] = number;
    }
    for (int i = 0;i <arr.Length; i++)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}