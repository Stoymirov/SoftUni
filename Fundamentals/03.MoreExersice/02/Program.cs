int n = int.Parse(Console.ReadLine());
int[] arrForControl = new int[1];
int controlNumber = 1;
Console.WriteLine(1);
for (int i = 0; i < n-1; i++) 
{
    
    int[] arr = new int[i+1];
    arr = arrForControl;
    int[] arrNext = new int[i+2];
    arr[0] = 1;
    arrNext[0] = 1;
    arr[arr.Length-1] = 1;
    arrNext[arr.Length] = 1;

    {
        for (int j = 1; j <= controlNumber; j++)
        {
            if (j == arr.Length)
            {
                break;
            }
            arrNext[j] = arr[j - 1] + arr[j];

        }
    }


    controlNumber++;
    Console.WriteLine(string.Join(" ",arrNext));
    arrForControl = arrNext;
}






//if (i == 3)
//{
//    Console.WriteLine(1);
//    continue;
//}
//else if (i == 1)
//{
//    Console.WriteLine(1 + " " + 1);
//    continue;
//}
//else if (i == 2)
//{
//    Console.WriteLine(1 + " " + 3 + " " + 1);
//    continue;
//}
//else