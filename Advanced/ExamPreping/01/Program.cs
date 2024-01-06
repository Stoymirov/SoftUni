using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

int[] worms = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] holes = Console.ReadLine().Split(" ", StringSplitOptions
    .RemoveEmptyEntries).Select(int.Parse).ToArray();
Stack<int> wormStack = new Stack<int>(worms);
Queue<int> holeQueue = new Queue<int>(holes);

int matches = 0;
bool aWormDied = false;
int wormsCount = wormStack.Count;
while (wormStack.Count > 0 && holeQueue.Count > 0)
{
    if (wormStack.Peek() == holeQueue.Peek())
    {
        matches++;
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
if (matches == 0)
{
    Console.WriteLine($"There are no matches.");
}
else
{
    Console.WriteLine($"Matches: {matches}");
}

if (wormStack.Count == 0 && matches == wormsCount)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (wormStack.Count == 0)
{
    Console.WriteLine($"Worms left: none");
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ", wormStack)}");
}

if (holeQueue.Count == 0)
{
    Console.WriteLine($"Holes left: none");
}
else
{
    Console.WriteLine($"Holes left: {string.Join(", ", holeQueue)}");
}
