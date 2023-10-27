
List<Box> boxes = new List<Box>();

string command = "";
while((command = Console.ReadLine()) != "end")
{
    string[] array = command.Split();
    int serialNumber = int.Parse(array[0]);
    string itemName = array[1];
    int itemQuantity = int.Parse(array[2]);
    decimal itemPrice = decimal.Parse(array[3]);

    Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice);

    boxes.Add(box);
}
boxes = boxes.OrderByDescending(x=>x.PriceForABox).ToList();
foreach(Box box in boxes)
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
    Console.WriteLine($"-- ${box.PriceForABox:f2}");
}





class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    
    public Box(int serialNumber, string item, int quantity, decimal itemPrice)
    {
        SerialNumber = serialNumber;
        Item = new Item();
        Item.Name = item;
        Quantity = quantity;
        Item.Price = itemPrice;
    }

    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal PriceForABox =>Quantity*Item.Price;
}