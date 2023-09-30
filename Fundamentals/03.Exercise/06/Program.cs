int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
bool isFound = false;
int foundnumber = 0;
for (int i = 0; i < arr.Length; i++)
{
    
    int sumOfj = 0;
    int sumOfk = 0;
    for (int j = 0; j < i ; j++)
    {
        sumOfj += arr[j];
    }
    for (int k = i+1; k < arr.Length; k++)
    {
        sumOfk += arr[k];
    }

    if (sumOfj == sumOfk)
    {
        isFound = true;
        foundnumber = i;
    }
    
}
if (isFound)
{
    Console.WriteLine(foundnumber);
}
else Console.WriteLine("no");