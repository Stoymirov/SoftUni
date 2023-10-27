using System.Numerics;

List<Box> myList = new List<Box>();


string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] array = command.Split().ToArray();

    long serialNumber = int.Parse(array[0]);
    string itemName = array[1];
    long itemQuantity = int.Parse(array[2]);
    decimal itemPrice = decimal.Parse(array[3]);

    Item item = new Item(itemName, itemPrice);
    Box boxes = new Box(item, itemQuantity, serialNumber);
    myList.Add(boxes);


}


foreach (Box box in myList.OrderByDescending(b=>b.BoxPrice))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.BoxPrice:F2}");
}




class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }

}

 class Box
{
    
   public Box(Item item, long quanity, long serialNumber)
   {
        Item = item;
        ItemQuantity = quanity;
        SerialNumber = serialNumber;
    }
    public long SerialNumber { get; set; }
    public Item Item { get; set; }
    public long ItemQuantity { get; set; }

    public decimal BoxPrice =>Item.Price * ItemQuantity;
    
}