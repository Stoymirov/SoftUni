//The count of students – integer in the range [0…100].
//• The price of lightsabers for a single saber – floating-point number in the range [0.00…100.00].
//• The price of robes for a single robe – floating-point number in the range [0.00…100.00].
//• The price of belts for a single belt – floating-point number in the range [0.00…100.00].
double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double priceOfLightsabers =  double.Parse(Console.ReadLine());
double robes =  double.Parse(Console.ReadLine());
double belts =  double.Parse(Console.ReadLine());

double numberOfLightsabers = Math.Ceiling(1.1 * students);
double beltsNumberFree = Math.Floor(students / 6.0);

double totalPrice = priceOfLightsabers*numberOfLightsabers + robes*students + belts*(students - beltsNumberFree);
if (totalPrice > money)
{
    Console.WriteLine($"John will need {Math.Abs(totalPrice-money):f2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
