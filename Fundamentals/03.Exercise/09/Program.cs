int lengthOfSamples = int.Parse(Console.ReadLine());

int[] bestSemple = new int[lengthOfSamples];
int bestSampleStartOfSequence = lengthOfSamples;
int bestSampleSequenseLenght = 0;
int bestSampleSum = 0;
int bestSampleNumber = 0;

string sampleStr = Console.ReadLine();

int sampleCounter = 0;

while (sampleStr != "Clone them!")
{
    sampleCounter++;

    int[] currentSample = sampleStr
                          .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();

    int currentSampleSum = currentSample.Sum();

    int currentSampleStartOfSequence = 0;
    int currentSampleSequenseLenght = 0;

    for (int i = 0; i < currentSample.Length - 1; i++)
    {
        int currentStart = i;
        int currentSequenceLength = 1;

        for (int j = i + 1; j < currentSample.Length; j++)
        {
            if (currentSample[i] == 1 && currentSample[j] == 1)
            {
                currentSequenceLength++;
            }
            else
            {
                break;
            }
        }

        if (currentSequenceLength > currentSampleSequenseLenght)
        {
            currentSampleStartOfSequence = currentStart;
            currentSampleSequenseLenght = currentSequenceLength;
        }
    }

    if (currentSampleSequenseLenght > bestSampleSequenseLenght)
    {
        bestSampleStartOfSequence = currentSampleStartOfSequence;
        bestSampleSequenseLenght = currentSampleSequenseLenght;
        bestSampleSum = currentSampleSum;
        bestSemple = currentSample;
        bestSampleNumber = sampleCounter;
    }
    else if (currentSampleSequenseLenght == bestSampleSequenseLenght)
    {
        if (currentSampleStartOfSequence < bestSampleStartOfSequence)
        {
            bestSampleStartOfSequence = currentSampleStartOfSequence;
            bestSampleSequenseLenght = currentSampleSequenseLenght;
            bestSampleSum = currentSampleSum;
            bestSemple = currentSample;
            bestSampleNumber = sampleCounter;
        }
        else if (currentSampleStartOfSequence == bestSampleStartOfSequence)
        {
            if (currentSampleSum > bestSampleSum)
            {
                bestSampleStartOfSequence = currentSampleStartOfSequence;
                bestSampleSequenseLenght = currentSampleSequenseLenght;
                bestSampleSum = currentSampleSum;
                bestSemple = currentSample;
                bestSampleNumber = sampleCounter;
            }
        }
    }

    sampleStr = Console.ReadLine();
}

Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampleSum}.");
Console.WriteLine(string.Join(" ", bestSemple));
        






























































//currentcycle++;
//int[] arr1 = string1.Split("!")
//    .Select(int.Parse)
//    .ToArray();

//for (int i = 0; i < arr1.Length; i++)
//{
//    bestcurrentSum += arr1[i];
//    if (arr1[0] == 1)
//    {
//        longestUpToNow++;
//    }
//    else if (arr1[0] == 0)
//    {
//        if (longestUpToNow > longestSequence)
//        {
//            longestSequence = longestUpToNow;
//            biggestSequenceCycle = currentcycle;
//        }
//        else if (longestUpToNow == longestSequence)
//        {

//        }

//        longestUpToNow = 0;
//    }

