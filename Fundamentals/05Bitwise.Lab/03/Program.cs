int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int bitAtPositionP = -1;
bitAtPositionP = (n >> p) & 1;
Console.WriteLine(bitAtPositionP);