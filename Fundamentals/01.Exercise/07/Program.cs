string coins = (Console.ReadLine());

double sum = 0;
while (coins != "Start")
{
    if (coins == "0.2" || coins == "0.1" || coins == "0.5" || coins == "1" || coins == "2")
    {
        sum += double.Parse(coins);
        coins = (Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"Cannot accept {coins}");
        coins = (Console.ReadLine());
    }
}
string product = Console.ReadLine();
while (product !="End")
{
    if(product == "Nuts")
    {
        if ( sum>=2)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            sum -= 2;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Water")
    {
        if (sum >= 0.7)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            sum -= 0.7;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Crisps")
    {
        if (sum >= 1.5)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            sum -= 1.5;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Soda")
    {
        if (sum >= 0.8)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            sum -= 0.8;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (product == "Coke")
    {
        if (sum >= 1)
        {
            Console.WriteLine($"Purchased {product.ToLower()}");
            sum -= 1;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
    product = Console.ReadLine();
}
Console.WriteLine($"Change: {sum:f2}");


