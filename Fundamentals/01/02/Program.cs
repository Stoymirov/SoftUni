using System.Net.Sockets;

List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

float timeSum1 = 0;
float timeSum2 = 0;

int finishIndex = (myList.Count+1)/2 -1;

for (int i = 0; i < finishIndex; i++)
{
    if (myList[i] == 0)
    {
        timeSum1 *= 0.8f;
    }
    else
    {
        timeSum1 += myList[i];
    }
}

for (int i = myList.Count - 1; i > finishIndex; i--)
{
    if(myList[i] == 0)
    {
        timeSum2 *= 0.8f;
    }
    else
    {
        timeSum2 += myList[i];
    }
}

if (timeSum1>timeSum2)
{
    Console.WriteLine($"The winner is right with total time: {timeSum2}");
}
else
    Console.WriteLine($"The winner is left with total time: {timeSum1}");