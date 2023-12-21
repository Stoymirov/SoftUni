HashSet<string> cars = new HashSet<string>();

string command = "";
while((command = Console.ReadLine()) !="END")
{
    string[] array = command.Split(", ");
    string action = array[0];
    string number = array[1];
    if (action == "IN")
    {
        cars.Add(number);
    }
    else
    {
        cars.Remove(number);
    }
}

if (cars.Count > 0)
{
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}