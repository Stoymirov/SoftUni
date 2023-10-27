List<string> myList = Console.ReadLine()
    .Split("||")
    .ToList();

int startFuel = int.Parse(Console.ReadLine());
int startAmmunition = int.Parse(Console.ReadLine());

for (int i = 0; i < myList.Count; i++)
{
    string[] commandArray = myList[i].Split().ToArray();
    string typeOfCommand = commandArray[0];

    if (typeOfCommand == "Titan")
    {
        Console.WriteLine("You have reached Titan, all passengers are safe.");
        return;
    }
    int number = int.Parse(commandArray[1]);

    if (typeOfCommand == "Travel")
    {
        if (startFuel - number >= 0)
        {
            Console.WriteLine($"The spaceship travelled {number} light-years.");
            startFuel -= number;

        }
        else
        {
            Console.WriteLine("Mission failed.");
            return;
        }
    }
    else if (typeOfCommand == "Enemy")
    {
        if (startAmmunition - number >= 0)
        {
            startAmmunition -= number;
            Console.WriteLine($"An enemy with {number} armour is defeated.");
        }
        else
        {
            if (startFuel - number * 2 >= 0)
            {
                startFuel -= number * 2;
                Console.WriteLine($"An enemy with {number} armour is outmaneuvered.");
            }
            else
            {
                Console.WriteLine("Mission failed.");
                return;
            }
        }
    }
    else if (typeOfCommand == "Repair")
    {
        int ammAdd = number * 2;
        int fuelAdd = number;
        startFuel += number;
        startAmmunition += number * 2;
        Console.WriteLine($"Ammunitions added: {ammAdd}.");
        Console.WriteLine($"Fuel added: {fuelAdd}.");
    }

}