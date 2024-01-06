using System.Runtime.InteropServices.ComTypes;

int[] worms = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] holes = Console.ReadLine().Split(" ", StringSplitOptions
    .RemoveEmptyEntries).Select(int.Parse).ToArray();
Stack<int> wormStack = new Stack<int>(worms);
Queue<int> holeQueue = new Queue<int>(holes);

int matchesCount = 0;
bool aWormDied = false;
while (wormStack.Count > 0 && holeQueue.Count > 0)
{
    if (wormStack.Peek() == holeQueue.Peek())
    {
        matchesCount++;
        wormStack.Pop();
        holeQueue.Dequeue();
    }
    else
    {
        holeQueue.Dequeue();
        int worm = wormStack.Pop();
        worm -= 3;
        if (worm <= 0)
        {
            aWormDied = true;
            continue;
        }
        wormStack.Push(worm);
    }
}

if (matchesCount != 0)
{
    Console.WriteLine($"Matches: {matchesCount}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if (!aWormDied && wormStack.Count == 0)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (wormStack.Count == 0)
{
    Console.WriteLine("Worms left: none");
}
else
{
    Console.Write($"Worms left: ");
    Console.WriteLine(string.Join(", ", wormStack));
}
//third
if (holeQueue.Count == 0)
{
    Console.WriteLine("Holes left: none");
}
else
{
    Console.Write($"Holes left: ");
    Console.WriteLine(string.Join(", ", holeQueue));
}