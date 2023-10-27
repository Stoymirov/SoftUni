using System.Data;

Catalog myCatalog = new Catalog();
string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] commandArray = command.Split("/").ToArray();
    string type = commandArray[0];
    string brand = commandArray[1];
    string model = commandArray[2];
    string horsePower = commandArray[3];
    if(type == "Car")
    {
        Car currentCar =new Car(brand, model , horsePower);
        myCatalog.Cars.Add(currentCar);
    }
    else
    {
        Truck currentTruck = new Truck(brand, model, horsePower);
        myCatalog.Trucks.Add(currentTruck);
    }
}

printCatalog(myCatalog);

//catologe foreach,

static void printCatalog(Catalog catalog)
{

    if (catalog.Cars.Count > 0)
    {
        Console.WriteLine("Cars:");
        foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePowers}hp");
        }
    }

    if (catalog.Trucks.Count > 0)
    {
        Console.WriteLine("Trucks:");
        foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }

        ;
    }

}

class Car
{
    public Car(string brand, string model, string horsePowers)
    {
        Brand = brand;
        Model = model;
        HorsePowers = horsePowers;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public string HorsePowers { get; set; }
}

class Catalog
{
    public Catalog()
    {
        Cars = new List<Car>() ;
        Trucks = new List<Truck>();
    }
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
}