int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = int.Parse( Console.ReadLine() );
int controlNumber = 0;
while (true)
{
    for (int i = 0 + controlNumber; i < arr.Length; i++)
    {
        if (controlNumber == i)
        {
            continue; 
        }
        if (arr[controlNumber] + arr[i] == n)
        {
            Console.WriteLine(arr[controlNumber] + " " + arr[i]);
        }

        
    }
    controlNumber++;
    if (controlNumber == arr.Length)
    {
        break;
    }
}