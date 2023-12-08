Queue<string> customers = new Queue<string>();
string command = "";


while ((command = Console.ReadLine()) != "End")
{
    if (command == "Paid")
    {
        int length = customers.Count;
        for (int i = 0; i < customers.Count; i++)
        {
            Console.WriteLine(customers.Dequeue());
        }
    }
    else
    {
        customers.Enqueue(command);
    }
}

Console.WriteLine($"{customers.Count} people remaining.");