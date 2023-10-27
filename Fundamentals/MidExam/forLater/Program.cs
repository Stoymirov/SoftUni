
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

        TravelCommand(number, startFuel);
    }
    else if (typeOfCommand == "Enemy")
    {
        EnemyCommand(number, startAmmunition, startFuel);
    }
    else if (typeOfCommand == "Repair")
    {
        RepairCommand(number, startAmmunition, startFuel);
    }

}

static void TravelCommand(int lightYears, int startFuel)
{

    ;
    if (startFuel - lightYears >= 0)
    {
        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
        startFuel -= lightYears;
    }
}

static void EnemyCommand(int enemyArmor, int ammunition, int startFuel)
{
    if (ammunition - enemyArmor >= 0)
    {
        ammunition -= enemyArmor;
        Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
    }
    else
    {
        if (startFuel - enemyArmor * 2 >= 0)
        {
            startFuel -= enemyArmor * 2;
            Console.WriteLine($"An enemy with {enemyArmor} is outmaneuvered.");
        }
        else
        {
            Console.WriteLine("Mission failed.");
            return;
        }
    }
}

static void RepairCommand(int number, int startAmmunition, int startFuel)
{
    int ammAdd = number * 2;
    int fuelAdd = number;
    startFuel += number;
    startAmmunition += number * 2;
    Console.WriteLine($"Ammunitions added: {ammAdd}.");
    Console.WriteLine($"Fuel added: {fuelAdd}.");
}
