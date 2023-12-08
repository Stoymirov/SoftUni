//stack of bottles
//queue of cups
//keepTrackOfWastedWater
int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> BottlesStack = new Stack<int>(bottles);
Queue<int> cupsQueue = new Queue<int>(cups);
int litersWastedWater = 0;

while(cupsQueue.Any() && BottlesStack.Any())
{
    int currentBottle = BottlesStack.Pop();
    int currentCup = cupsQueue.Dequeue();
    if(currentBottle-currentCup > 0)
    {
        litersWastedWater += currentBottle - currentCup;
        
    }
    else
    {
        currentCup -= currentBottle;
        while(currentCup>0)
        {
            currentCup -= BottlesStack.Pop();
        }
        litersWastedWater += Math.Abs(currentCup);
    }
}
if(cupsQueue.Any())
{
    Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", BottlesStack)}");
}
Console.WriteLine($"Wasted litters of water: {litersWastedWater}.");