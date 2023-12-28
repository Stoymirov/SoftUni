Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> queueChecker = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
int count = stack.Count;
for (int i = 1; i <= count; i++)
{
    if (stack.Pop() - queue.Dequeue() >= queueChecker.Dequeue())
    {
        Console.WriteLine($"John has reached: Altitude {i}");
    }
    else
    {
        Console.WriteLine($"John did not reach: Altitude {i}");
        Console.WriteLine("John failed to reach the top.");
        if (i != 1)
        {
            Console.Write("Reached altitudes: ");
            for (int j = 1; j < i; j++)
            {
                Console.Write($"Altitude {j}");
                if (j != i - 1)
                {
                    Console.Write(", ");
                }

            }
        }
        else
        {
            Console.WriteLine("John didn't reach any altitude.");
        }

        return;
    }
}

Console.WriteLine("John has reached all the altitudes and managed to reach the top!");

