Dictionary<string, Dictionary<string, double>> Shops = new Dictionary<string, Dictionary<string, double>>();
string command = "";
while ((command = Console.ReadLine()) != "Revision")
{
    string[] workedUp = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string shop = workedUp[0];
    string item = workedUp[1];
    double price = double.Parse(workedUp[2]);

    if (!Shops.ContainsKey(shop))
    {
        Shops.Add(shop, new Dictionary<string, double>());
    }
    Shops[shop].Add(item, price);

}

foreach (var shop in Shops.OrderBy(x=>x.Key))
{
    Console.WriteLine(shop.Key + "->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}