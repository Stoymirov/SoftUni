Queue<string> people = new Queue<string>();

people.Enqueue("Dimitrichko");
people.Enqueue("Goshko");
people.Enqueue("NIki");
people.Enqueue("Dimo");

Console.WriteLine($"Next in line: {people.Dequeue()}");
Console.WriteLine($"Next in line: {people.Dequeue()}");