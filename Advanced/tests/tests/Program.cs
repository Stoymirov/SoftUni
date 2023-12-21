using tests;

var vehicle = new Vehicle()
{
    Color = "grgey",
    ID = 26,
    Name = "abc",
    TirePressure = 65,
    Weight = 1254500
};
var vehicle2 = new Vehicle()
{
    Color = "grfey",
    ID = 235,
    Name = "abc",
    TirePressure = 65,
    Weight = 15020
};
bool areEqual  = vehicle.Equals(vehicle2);
Console.WriteLine(areEqual);

