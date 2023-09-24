int lines = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < lines; i++)
{
    int litersOfWater = int.Parse(Console.ReadLine());
    sum += litersOfWater;
    if (sum > 255)
    {
        Console.WriteLine("Insufficient capacity!");
        sum -= litersOfWater;
        continue;
    }
   
}
Console.WriteLine(sum);
