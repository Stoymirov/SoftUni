using System.Drawing;
using System.Reflection;
using System.Security;

string command = "";
List<Vehicle> vehicles = new List<Vehicle>();

while ((command = Console.ReadLine()) != "End")
{
    string[] array = command.Split().ToArray();
   
    Vehicle vehicle = new Vehicle();
    if (array[0] == "car")
    {
        vehicle.Type = "Car";
        vehicle.Model = array[1];
        vehicle.Color = array[2];
        vehicle.HorsePower = double.Parse(array[3]);
       vehicles.Add(vehicle);
    }
    else
    {
        vehicle.Type = "Truck";
        vehicle.Model = array[1];
        vehicle.Color = array[2];
        vehicle.HorsePower = double.Parse(array[3]);
        vehicles.Add(vehicle);
    }

}
string nextCommand = "";
while ((nextCommand = Console.ReadLine()) != "Close the Catalogue")
{
    Vehicle vehicle = new Vehicle();
    
     int vehicleIndex = vehicles.FindIndex(x=>x.Model == nextCommand);
    Console.WriteLine(vehicles[vehicleIndex]);
}
double truckHorsePower = 0;
double carHorsePower = 0;
foreach (Vehicle vehicle in vehicles)
{
    if(vehicle.Type == "Truck")
    {
        truckHorsePower += vehicle.HorsePower;
    }else
    {
        carHorsePower += vehicle.HorsePower;
    }
}
int countTrucks = vehicles.Count(x => x.Type == "Truck");
int countCars = vehicles.Count(x => x.Type == "Car");
if (countCars > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {carHorsePower / countCars:f2}.");

}
else
{
    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
}

if (countTrucks > 0)
{
    Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower / countTrucks:f2}.");
}
else
{
    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
}

//Console.WriteLine($"Cars have average horsepower of: {carHorsePower/countCars:f2}.");//cant divide by 0!!!
//Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower/countTrucks:f2}.");



class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double HorsePower { get; set; }
    public override string ToString()
    {
        return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
    }
}