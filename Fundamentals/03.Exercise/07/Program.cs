using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int biggestSecquence = 0;
int currentBiggetSequence = 1;
int intToBe = 0;
for (int i = 0; i < arr.Length - 1; i++)
{

    if (arr[i] == arr[i + 1])
    {
        currentBiggetSequence++;
    }
    else currentBiggetSequence = 1;


    if (currentBiggetSequence > biggestSecquence)
    {
        biggestSecquence = currentBiggetSequence;
        intToBe = arr[i];
    }


}
int[] resultArray = new int[biggestSecquence];
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = intToBe;
}
Console.WriteLine(string.Join(" ", resultArray));