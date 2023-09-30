int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string answer = "";
for (int i = 0; i < arr.Length; i++)
{
    bool biggerNumberFound = false;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] >= arr[i])
        {
            biggerNumberFound = true;
            break;
        }
       
    }
    if (!biggerNumberFound)
    {
        answer += arr[i].ToString() + " ";
    }
}
Console.WriteLine(answer);