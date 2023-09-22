double currentBalance = double.Parse(Console.ReadLine());
string game = Console.ReadLine();
while (game != "Game Time")
{
    switch (game)
    {
        case "OutFall 4":
            Console.WriteLine("Bought OutFall 4");
            currentBalance -= 39.99;
            break;
        case "CS: OG":
            Console.WriteLine("Bought CS: OG");
            currentBalance -= 15.99;
            break;
        case "Zplinter Zell":
            Console.WriteLine("Zplinter Zell");
            currentBalance -= 19.99;
            break;
        case "Honored 2":
            Console.WriteLine("Bought Honored 2");
            currentBalance -= 59.99;
            break;
        case "RoverWatch":
            Console.WriteLine("Bought RoverWatch");
            currentBalance -= 29.99;
            break;
        case "RoverWatch Origins Edition":
            Console.WriteLine("RoverWatch Origins Edition");
            currentBalance -= 39.99;
            break;
            default: Console.WriteLine("Not Found");break;
    }
    game = Console.ReadLine();
}