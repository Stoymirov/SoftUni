int dnaLength = int.Parse(Console.ReadLine());

int[] input = new int[dnaLength];
int[] bestDna = new int[dnaLength];

int bestIndex = 0;
int bestSequenceSum = 0;
int currentProbeNumber = 0;
int bestProbeNumber = 0;
string command = string.Empty;
int bestArraySum = 0;




while ((command = Console.ReadLine()) != "Clone them!")
{
    input = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    currentProbeNumber++;
    int currentSequenceSum = 0;

    for (int i = 0; i < dnaLength; i++)
    {
        if (input[i] == 0 && currentSequenceSum > 0)
        {
            break; ;
        }
        else if (input[i] == 1)
        {
            currentSequenceSum++;
        }
        int currentArraySum = input.Sum();
        int currentIndex = Array.IndexOf(input, 1);// finds the first occurance of the index

        if (currentSequenceSum > bestSequenceSum
         || currentSequenceSum == bestSequenceSum && currentIndex < bestIndex
         || currentSequenceSum == bestSequenceSum && currentIndex == bestIndex && currentArraySum > bestArraySum)
        {
            bestSequenceSum = currentSequenceSum;
            bestIndex = currentIndex;
            bestArraySum = currentArraySum;
            bestDna = input;
            bestProbeNumber = currentProbeNumber;
        }
    }
}
Console.WriteLine($"Best DNA sample {bestProbeNumber} with sum: {bestArraySum}.");
Console.WriteLine(string.Join(" ", bestDna));
		
		
