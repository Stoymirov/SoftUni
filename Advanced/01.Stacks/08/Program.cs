Queue<string> cars = new Queue<string>();

int carsPerLight = int.Parse(Console.ReadLine());
string command = "";
int carsToPass = 0;
while ((command=Console.ReadLine()) != "end")
{
    
    if (command == "green")
    {
        for (int i = 0; i < carsPerLight; i++)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine($"{cars.Dequeue()} passed!");
                carsToPass++;
            }
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}

Console.WriteLine($"{carsToPass} cars passed the crossroads.");