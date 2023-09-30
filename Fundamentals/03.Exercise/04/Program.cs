int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotationNumber = int.Parse(Console.ReadLine());
for (int i = 0; i < rotationNumber; i++)
{
    int currentFirstNumber = arr[0];
    int totalNumbers = arr.Length;
    for (int j = 0; j < totalNumbers-1; j++)
    {
        
        arr[j] = arr[j+1];
    }
    arr[totalNumbers - 1] = currentFirstNumber;
}
Console.WriteLine(string.Join(" ", arr));
