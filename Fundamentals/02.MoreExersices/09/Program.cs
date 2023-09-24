long n = int.Parse(Console.ReadLine());
long days = 0;
long yield = 0;
while (n >=100)
{
    yield += n - 26;    
    n -= 10;
    
    days++;
}
if (yield <= 26)
{
    yield = 0;
}
else
    yield -= 26;
Console.WriteLine(days);
Console.WriteLine(yield);