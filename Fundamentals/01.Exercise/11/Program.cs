int n = int.Parse(Console.ReadLine());

double totalSum = 0;
for( int i = 0; i <n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double currentprice = days * pricePerCapsule * capsulesCount;
    totalSum += currentprice;
    Console.WriteLine($"The price for the coffee is: ${currentprice:f2}");
}
Console.WriteLine($"Total: ${totalSum:f2}");
