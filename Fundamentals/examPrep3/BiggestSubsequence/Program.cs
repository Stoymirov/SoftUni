int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] LongestSubsequenceAtAnyPoint = new int[inputArray.Length];
int[] previusBiggestElementAtAnyPoint = new int [inputArray.Length];

LongestSubsequenceAtAnyPoint[0] = 1;
previusBiggestElementAtAnyPoint[0] = -1;
for (int i = 0; i < inputArray.Length; i++)
{
    LongestSubsequenceAtAnyPoint[i] = 1;
    previusBiggestElementAtAnyPoint[i] = -1;
    for (int j = 0; j < i; j++)
    {
        if (inputArray[j] < inputArray[i] && LongestSubsequenceAtAnyPoint[i] < LongestSubsequenceAtAnyPoint[j]+1)
        {
            LongestSubsequenceAtAnyPoint[i] = LongestSubsequenceAtAnyPoint[j] + 1;
            previusBiggestElementAtAnyPoint[i] = j;
        }
    }
}
int maxNumber = LongestSubsequenceAtAnyPoint.Max();
int indexOfMax = Array.IndexOf(LongestSubsequenceAtAnyPoint, maxNumber);
int[] arrayOfSequence = new int[maxNumber];

for (int i = maxNumber-1; i >= 0; i--)
{
    int number = inputArray[indexOfMax];
    arrayOfSequence[i] = number;
    indexOfMax = previusBiggestElementAtAnyPoint[indexOfMax];
}

Console.WriteLine(string.Join(" ",arrayOfSequence));