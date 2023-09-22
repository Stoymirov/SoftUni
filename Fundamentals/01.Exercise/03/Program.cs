int countOfPeople = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double ticketPrice = 0;
if (dayOfWeek == "Friday")
{
    switch (groupType)
    {
        case "Students":
            ticketPrice = 8.45;
            break;
        case "Business":
            ticketPrice = 10.90;
            break;
        case "Regular":
            ticketPrice = 15;
            break;
    }
}
else if (dayOfWeek == "Saturday")
{
    switch (groupType)
    {
        case "Students":
            ticketPrice = 9.8;
            break;
        case "Business":
            ticketPrice = 15.6;
            break;
        case "Regular":
            ticketPrice = 20;
            break;
    }   
}
else if (dayOfWeek == "Sunday")
{
    switch (groupType)
    {
        case "Students":
            ticketPrice = 10.46;
            break;
        case "Business":
            ticketPrice = 16;
            break;
        case "Regular":
            ticketPrice = 22.5;
            break;
    }
}
double totalPrice = ticketPrice * countOfPeople;
if (groupType == "Students" && countOfPeople >=30)
{
    totalPrice *= 0.85;
}
else if (groupType == "Business" && countOfPeople >= 100)
{
    totalPrice -= 10 * ticketPrice;
}
else if (groupType == "Regular" && (countOfPeople >=10 && countOfPeople <=20))
{
    totalPrice *= 0.95;
}
Console.WriteLine($"Total price: {totalPrice:f2}");