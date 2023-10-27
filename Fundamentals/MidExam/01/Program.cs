int numberOfCities = int.Parse(Console.ReadLine());

int counter = 1;
double totalProfit = 0;
for (int i = 0; i < numberOfCities; i++)
{
    string nameOfCity = Console.ReadLine();
    double moneyOwned = double.Parse(Console.ReadLine());
    double expenses = double.Parse(Console.ReadLine());
    

    if (counter % 5 == 0)
    {
        moneyOwned *= 0.9;
    }
    if (counter % 3 == 0 && counter%5!=0)
    {
        expenses *= 1.5;
    }

    double dailyProfit = moneyOwned - expenses;
    Console.WriteLine($"In {nameOfCity} Burger Bus earned {dailyProfit:f2} leva.");

   totalProfit += dailyProfit;
   counter++;
}

Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");