using System.ComponentModel.DataAnnotations;

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] longestSequenceArray = new int[arr.Length];// this array contains the longest lenghts at any point
int[] prevNumbOfSubsequece = new int[arr.Length];
prevNumbOfSubsequece[0] = -1;
longestSequenceArray[0] = 1;
for (int i = 0; i < arr.Length; i++)
{
    longestSequenceArray[i] = 1;
    prevNumbOfSubsequece[i] = -1;
    for (int j = 0; j <i ; j++)
    {
        
        if (arr[j] < arr[i] && longestSequenceArray[i] < longestSequenceArray[j] + 1)
        {
            longestSequenceArray[i] = 1 + longestSequenceArray[j];
            prevNumbOfSubsequece[i] = j;
        }
       
    }
}
int max = longestSequenceArray.Max();
int[] resultArray =  new int[max];
int controlKey = Array.IndexOf(longestSequenceArray, max); ;//first encounter of the number max in the array longestsequence;
for (int i = max-1; i >= 0; i--)
{
    resultArray[i] = arr[controlKey];
    controlKey = prevNumbOfSubsequece[controlKey];
}
Console.WriteLine(string.Join(" ",resultArray));