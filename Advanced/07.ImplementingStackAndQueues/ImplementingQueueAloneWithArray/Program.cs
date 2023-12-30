using ImplementingQueueAloneWithArray;

Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Dequeue();
Console.WriteLine(queue.Count);
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
queue.Enqueue(23);
queue.Enqueue(23);
queue.Enqueue(23);
queue.Foreach(x => Console.WriteLine(x + " "));

queue.Clear();
Console.WriteLine();
Console.WriteLine(queue.Count);
