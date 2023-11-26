using System.Diagnostics.CodeAnalysis;

Dictionary<string, City> myCities = new Dictionary<string, City>();


string command = String.Empty;
while ((command = Console.ReadLine()) != "Sail")
{
    string[] array = command
        .Split("||")
        .ToArray();
    string name = array[0];
    int population = int.Parse(array[1]);
    int gold = int.Parse(array[2]);
    if (!myCities.ContainsKey(name))
    {
        City city = new City();
        city.Gold = gold;
        city.Population = population;

        myCities.Add(name, city);
    }
    else
    {
        myCities[name].Gold += gold;
        myCities[name].Population += population;
    }
}
string command2 = String.Empty;
while ((command2 = Console.ReadLine()) != "End")
{
    string[] array = command2.Split("=>").ToArray();
    if (array.Length == 4)
    {
        myCities[array[1]].Gold -= int.Parse(array[3]);
        myCities[array[1]].Population -= int.Parse(array[2]);
        Console.WriteLine($"{array[1]} plundered! {array[3]} gold stolen, {array[2]} citizens killed.");
        if (myCities[array[1]].Gold <= 0 || myCities[array[1]].Population <= 0)
        {
            Console.WriteLine($"{array[1]} has been wiped off the map!");
            myCities.Remove(array[1]);
        }
    }
    else
    {
        if (int.Parse(array[2]) <= 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
        else
        {
            myCities[array[1]].Gold += int.Parse(array[2]);
            Console.WriteLine($"{array[2]} gold added to the city treasury. {array[1]} now has {myCities[array[1]].Gold} gold.");
        }
    }
}

if (myCities.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {myCities.Count} wealthy settlements to go to:");
    foreach (var myCity in myCities)
    {
        Console.WriteLine(
            $"{myCity.Key} -> Population: {myCity.Value.Population} citizens, Gold: {myCity.Value.Gold} kg");
    }
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}

class City
{
    public int Gold { get; set; }
    public int Population { get; set; }
}