int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(input.Take(array[0]));

while (queue.Any() && array[1] > 0)
{
    queue.Dequeue();
    array[1]--;
}

if (queue.Contains(array[2]))
{
    Console.WriteLine("true");
}
else if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else Console.WriteLine(queue.Min());