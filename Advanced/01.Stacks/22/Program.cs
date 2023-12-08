Queue<int> queue =  new Queue<int>();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
foreach (var i in input)
{
    if (i % 2 == 0)
    {
        queue.Enqueue(i);
    }
}

Console.WriteLine(string.Join(", ",queue));