int foodQuantity = int.Parse((Console.ReadLine()));

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>(orders);
Console.WriteLine(orders.Max());
while (queue.Count > 0 && foodQuantity > 0)
{
    int currentOrder = queue.Peek();
    if (foodQuantity - currentOrder >=  0)
    {
        foodQuantity -= queue.Dequeue();
    }
    else
    {
        break;
    }
}

if (queue.Count == 0)
{
   
    Console.WriteLine("Orders complete");
}
else
{
    
    Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
}