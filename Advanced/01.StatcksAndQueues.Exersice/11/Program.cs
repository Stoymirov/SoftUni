int bulletPrice = int.Parse(Console.ReadLine());
int gunBarrel = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int valueOfIntelligence = int.Parse(Console.ReadLine());

Queue<int> locksQueue = new Queue<int>(locks);
Stack<int> bulletsStack = new Stack<int>(bullets);
int currentBulletNumber = 0;
int bulletsSpent = 0;
while (locksQueue.Any() && bulletsStack.Any())
{
    currentBulletNumber++;
    int currentBullet = bulletsStack.Pop();
    int currentLock = locksQueue.Peek();

    if (currentBullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        locksQueue.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    bulletsSpent++;
    if (currentBulletNumber == gunBarrel && bulletsStack.Any())
    {
        Console.WriteLine("Reloading!");
        currentBulletNumber = 0;
    }
}

if (bulletsStack.Count == 0 && locksQueue.Any())
{
    Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
}
else
{
    Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${valueOfIntelligence-(bulletsSpent*bulletPrice)}");
}