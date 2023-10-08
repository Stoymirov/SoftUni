static double MathPower(double a, double b)
{if (b == 0)
    {
        return 1;
    }
    double result = a;
   for (int i = 1; i < b; i++)
    {
       result *= a;
    }
   return result;
}
double a = double.Parse(Console.ReadLine());
double b = int.Parse(Console.ReadLine());
Console.WriteLine(MathPower(a,b));