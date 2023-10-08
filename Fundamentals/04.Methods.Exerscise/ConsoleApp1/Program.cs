static void PrintowestNumber(int[] arr)
{
    int lowestNumber = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < lowestNumber) { lowestNumber = arr[i];}
    }
    Console.WriteLine(lowestNumber);
}
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int[] arr = new int[3] {n1,n2,n3};
PrintowestNumber(arr);