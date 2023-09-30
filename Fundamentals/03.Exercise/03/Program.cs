int n = int.Parse(Console.ReadLine());

int[] arr1 = new int[n];
int[] arr2 = new int[n];

int positionArr = 0;

for (int i = 0; i < n; i++)
{
    int[] arr3 = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (i % 2 != 0)
    {
        arr1[i] = arr3[1];
        arr2[i] = arr3[0];
        
    }
    else
    {
        arr2[i] = arr3[1];
        arr1[i] = arr3[0];
        
    }
}
Console.WriteLine(string.Join(" ", arr1));
Console.WriteLine(string.Join(" ", arr2));