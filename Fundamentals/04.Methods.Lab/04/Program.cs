//Create a program that receives three lines of input:
//• On the first line – a string – "add", "multiply", "subtract", "divide".
//• On the second line – a number.
//• On the third line – another number.
//You should create four methods (for each calculation) and invoke the corresponding method depending on the 
//command. The method should also print the result (needs to be void).

static void Subtract(int n, int m)
{
   int result = n - m;
    Console.WriteLine(result);
}
static void Add(int n, int m)
{
    int result = n + m;
    Console.WriteLine(result);
}
static void multiply(int n, int m)
{
    int result = n * m;
    Console.WriteLine(result);
}
static void Divide(int n, int m)
{
    int result = n / m;
    Console.WriteLine(result);
}

string text = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
switch (text)
{
    case "add":
        Add(n,m); break;
    case "subtract":
        Subtract(n, m); break;
    case "multiply":
        multiply(n, m); break;
    case "divide":
        Divide(n, m); break;
    
}
