int n = int.Parse(Console.ReadLine());
Queue<(int, int)> pumps = new Queue<(int, int)>();
for (int i = 0; i < n; i++)
{
    int[] array = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    int amountOfPetrol = array[0];
    int distance = array[1];
    pumps.Enqueue((amountOfPetrol, distance));
}
int bestRoute = 0;
while (true)
{
    int totalPetrol = 0;
    foreach (var pump in pumps)
    {
       totalPetrol+= pump.Item1;
        int distance = pump.Item2;
        if (totalPetrol - distance <0)
        {
            totalPetrol = 0;
            pumps.Enqueue(pumps.Dequeue());
            break;
        }
        else
        {
            totalPetrol -= distance;
        }
    }
    if (totalPetrol > 0)
    {
        break;
    }
    bestRoute++;
}

Console.WriteLine(bestRoute);