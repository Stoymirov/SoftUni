int input = int.Parse(Console.ReadLine());
for (int i = 2; i <= input; i++)
{
    bool isPrime = true;
    for (int cepitel = 2; cepitel < i; cepitel++)
    {
        if (i % cepitel == 0)
        {
            isPrime = false;
            break;
        }
    }
    string primeOrNo = isPrime ? "true" : "false";
    Console.WriteLine($"{i} -> {primeOrNo}");
}
