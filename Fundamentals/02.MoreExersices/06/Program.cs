int n = int.Parse(Console.ReadLine());
char first = (char)0;
char second = (char)0;
char third = (char)0;
for (int i = 0; i < n; i++)
{
     first = (char)(97 + i);
    for (int j = 0; j < n; j++)
    {
        second = (char)(97 + j);
        for (int k = 0; k < n; k++)
        {
            third = (char)(97 + k);
            Console.WriteLine($"{first}{second}{third}");

        }
    }
}