using System.Text.RegularExpressions;

Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[^<>]+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$");

double totalIncome = 0;

string command = "";
while ((command = Console.ReadLine()) != "end of shift")
{
    Match match = regex.Match(command);
    if (match.Success)
    {
        string name = match.Groups["name"].Value;
        string product = match.Groups["product"].Value;
        string quantity = match.Groups["quantity"].Value;
        string price = match.Groups["price"].Value;

        double currentIncome = double.Parse(price) * double.Parse(quantity);
        totalIncome += currentIncome;
        Console.WriteLine($"{name:f2}: {product:f2} - {currentIncome:f2}");
    }
}

Console.WriteLine($"Total income: {totalIncome:f2}");