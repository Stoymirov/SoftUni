using System.Diagnostics.CodeAnalysis;


double price = 0;
double taxes = 0;

string command = "";
while((command=Console.ReadLine()) != "special" && command !="regular")
{
    double productPrice = double.Parse(command);
    if (productPrice < 0)
    {
        Console.WriteLine("Invalid price!");
        continue;
    }
   
    
    price += productPrice;

}

if (price == 0)
{
    Console.WriteLine("Invalid order!");
    return;
}

taxes = 0.2 * price;
    if (command == "regular")
    {

        Console.WriteLine(
            $"Congratulations you've just bought a new computer!\r\nPrice without taxes: {price:f2}$\r\nTaxes: {taxes:f2}$\r\n-----------\r\nTotal price: {price + taxes:f2}$");
    }
    else
    {
        Console.WriteLine(
            $"Congratulations you've just bought a new computer!\r\nPrice without taxes: {price:f2}$\r\nTaxes: {taxes:f2}$\r\n-----------\r\nTotal price: {(0.9 * (price + taxes)):f2}$");
    }
