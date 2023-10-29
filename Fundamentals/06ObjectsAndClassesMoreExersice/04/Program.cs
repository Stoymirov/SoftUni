int n = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < n; i++)
{
    string[] array = Console.ReadLine().Split();

    Car car = new Car();
    car.Model = array[0];
    car.Engine.EngineSpeed = int.Parse(array[1]);
    car.Engine.EnginePower = int.Parse(array[2]);
    car.Cargo.CargoWeight = int.Parse(array[3]);
    car.Cargo.CargoType = array[4];
    cars.Add(car);
}
string command = Console.ReadLine();
switch (command)
{
    case "flamable":
        List<Car> flamableCars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
        foreach (Car car in flamableCars)
        {
            Console.WriteLine(car);
        }
        break;
    case "fragile":
        List<Car> fragileCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();
        foreach (Car car in fragileCars)
        {
            Console.WriteLine(car);
        }
        break;
}












class Car
{
    public Car()
    {
         Engine = new Engine();
         Cargo = new Cargo();
        
    }
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }

    public override string ToString()
    {
        return Model;
    }
}

class Engine
{
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
}

class Cargo
{
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }

}