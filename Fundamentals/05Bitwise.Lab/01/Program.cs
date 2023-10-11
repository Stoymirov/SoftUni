int n = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int counter = 0;
while (n != 0) {
    int ramainer = n % 2;
    n = n / 2;
    if (ramainer == b) { counter++; }
        }

Console.WriteLine(counter);