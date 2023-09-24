int numerOfLines = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < numerOfLines; i++)
{
   char a =char.Parse(Console.ReadLine());
    sum += a;
}

Console.WriteLine($"The sum equals: {sum}");