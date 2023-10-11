int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

int mask =( 1<<p);
mask = ~mask;
Console.WriteLine(mask&n);