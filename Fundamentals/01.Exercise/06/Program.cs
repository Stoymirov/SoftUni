
string n = (Console.ReadLine());
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    int factoriel = 1;
    int currentNumber = int.Parse(n[i].ToString());
   for (int j = 1; j <= currentNumber; j++)
    {
        factoriel *= j;
       
    }
    sum += factoriel;
}
if (sum == int.Parse(n))
{ 
    Console.WriteLine("yes");
}
else Console.WriteLine("no");
