int greenLightSeconds = int.Parse(Console.ReadLine());
int freeWindowSeconds = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int carsPassed = 0;
string command = "";
while ((command = Console.ReadLine()) != "END")
{
    if (command != ("green"))
    {
        cars.Enqueue(command);
    }
    else
    {
            int currentGreenLightSeconds = greenLightSeconds;
        while (cars.Any() && currentGreenLightSeconds>0)
        {
            
            string lastCarLength = cars.Dequeue();
            if (lastCarLength.Length <= currentGreenLightSeconds)
            {
                currentGreenLightSeconds -= lastCarLength.Length;
                carsPassed++;
            }
            else if (currentGreenLightSeconds + freeWindowSeconds - lastCarLength.Length >= 0)
            {
                
                    carsPassed++;
                    break;
                
            }
            else
            {
                int index = currentGreenLightSeconds + freeWindowSeconds;
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{lastCarLength} was hit at {lastCarLength[index]}.");
                Environment.Exit(0);
            }
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");