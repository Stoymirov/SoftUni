using System.Text.RegularExpressions;

Regex regex = new Regex(@">>(?<name>[A-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)");

string command = "";
double totalSum = 0;

    Console.WriteLine("Bought furniture:");

while ((command = Console.ReadLine()) != "Purchase")
{
   

    Match match = regex.Match(command);
    if (match.Success)
    {
       

        string itemName = match.Groups["name"].Value;
        string numberStr = match.Groups["price"].Value;
        string quantityStr = match.Groups["quantity"].Value;
        totalSum += double.Parse(numberStr) * double.Parse(quantityStr);
        Console.WriteLine(itemName);
    }

    
}

Console.WriteLine($"Total money spend: {totalSum:f2}");


