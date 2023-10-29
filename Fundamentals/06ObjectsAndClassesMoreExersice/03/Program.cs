using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();
for (int i = 0; i < n; i++)
{
    List<string> list = Console.ReadLine()
        .Split()
        .ToList();

    Car car = new Car(list[0], double.Parse(list[1]), double.Parse(list[2]));
    cars.Add(car);
}

string command = "";

while ((command = Console.ReadLine()) != "End")
{
    List<string> list = command
        .Split()
        .ToList();

    string carModel = list[1];
    double distanceToTravel = double.Parse(list[2]);
    Car car = new Car();
    car.DrivingMethod(carModel, distanceToTravel,cars);
}

foreach (Car car in cars)
{
    Console.WriteLine(car);
}





class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
    }

    public Car()
    {

    }
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TraveledDistance { get; set; }

    public void DrivingMethod(string modelOfCar, double distanceToTravel, List<Car> list)
    {
        Car car = list.Find(x => x.Model == modelOfCar);

        if (car.FuelAmount - car.FuelConsumptionPerKilometer*distanceToTravel < 0)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            car.FuelAmount -= distanceToTravel*car.FuelConsumptionPerKilometer;
            car.TraveledDistance += distanceToTravel;
        }

    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {TraveledDistance}";
    }
}