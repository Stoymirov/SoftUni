int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int NOriginal = N;
int pokedTargets = 0;
while (N>=M)
{
    N -= M;
    pokedTargets++;
    if (NOriginal/2 == N)
    {

        if (Y != 0)
        {
            N /= Y;
        }
        
    }
}
Console.WriteLine(N);    
Console.WriteLine(pokedTargets);    