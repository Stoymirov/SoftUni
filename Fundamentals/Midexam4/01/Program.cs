double food = double.Parse(Console.ReadLine())*1000;
double hay = double.Parse(Console.ReadLine())*1000;
double cover = double.Parse(Console.ReadLine())*1000;
double weight = double.Parse(Console.ReadLine()) * 1000;
int day = 1;
for (int i = day; i <= 30; i++)
{
    food -= 300;
    if (day % 2 == 0)
    {
        double haygiven = 0.05 * food;
        hay -= haygiven;
    }

    if (day % 3 == 0)
    {
        cover -= weight / 3;
    }

    day++;
}

if (cover >= 0 && food >= 0 && hay >= 0)
{
    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
}
else
{
    Console.WriteLine("Merry must go to the pet store!");
}