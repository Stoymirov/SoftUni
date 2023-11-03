using System.Data;

Dictionary<string, ProductInfo> ResourceMap = new Dictionary<string, ProductInfo>();

string command = "";
while ((command = Console.ReadLine()) != "buy")
{
    string[] array = command.Split().ToArray();

    string productName = array[0];
    double price = double.Parse(array[1]);
    int quantity = int.Parse(array[2]);

    ProductInfo productInfo = new ProductInfo(productName, price, quantity);
    if (!ResourceMap.ContainsKey(productInfo.Name))
    {
        ResourceMap.Add(productName, productInfo);
    }
    else
    {
        ResourceMap[productInfo.Name].Update(productInfo.Price, productInfo.Quantity);

    }
}

foreach (var VARIABLE in ResourceMap)
{
    Console.WriteLine($"{VARIABLE.Key} -> {VARIABLE.Value}");
}








class ProductInfo
{
    public ProductInfo(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;

    }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public void Update(double price, int quantity)
    {
        this.Price = price;
        this.Quantity += quantity;
    }
    public override string ToString()
    {
        return ($"{Price * Quantity:f2}");

    }
}