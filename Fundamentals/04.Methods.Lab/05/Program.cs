static void TotalPrice(string product, int quantity)
{
	switch (product)
	{
		
		case "coffee":
            Console.WriteLine($"{1.5*quantity:f2}"); break;
        case "water":
            Console.WriteLine($"{1*quantity:f2}"); break;
        case "coke":
            Console.WriteLine($"{1.4*quantity:f2}"  ); break;
        case "snacks":
            Console.WriteLine($"{2*quantity:f2}"); break;
        
	}
}
string text = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
TotalPrice(text, quantity);