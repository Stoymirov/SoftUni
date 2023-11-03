Dictionary<string, ProductInfo> ResourceMap = new Dictionary<string, ProductInfo>();

string command = "";
while ((command = Console.ReadLine()) != "buy")
{
    string[] array = command.Split().ToArray();
    ProductInfo productInfo = new ProductInfo();

    string productName = array[0];
    double price = double.Parse(array[1]);
    int quantity = int.Parse(array[2]);
    if (!ResourceMap.ContainsKey(productName))
    {
        ResourceMap.Add(productName, productInfo);
        ResourceMap[productName] = productInfo;
    }

    ResourceMap[productName].Price = double.Parse(array[1]);
    ResourceMap[productName].Quantity += int.Parse(array[2]);
}

foreach (var VARIABLE in ResourceMap)
{
    Console.WriteLine($"{VARIABLE.Key} -> {VARIABLE.Value}");
}








class ProductInfo
{
    public double Price { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return ($"{Price * Quantity:f2}");

    }
}