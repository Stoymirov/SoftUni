Queue<string> children = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());

int currentToss = 0;
while (children.Count > 1)
{
    string person = children.Dequeue();
    currentToss++;
    if (currentToss == tossCount)
    {
        Console.WriteLine($"Removed {person}");
        currentToss = 0;
    }
    
    else
    {
        children.Enqueue(person);
    }
}

Console.WriteLine($"Last is {children.Dequeue()}");