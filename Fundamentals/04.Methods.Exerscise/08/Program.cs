//2 methods for the 2 numbers 

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{Number1Factorial(number1) / Number1Factorial(number2):f2}");
static double Number1Factorial(int number1)
{
	double result = 1;
	for (int i = 1; i <= number1; i++)
	{
		result *= i;
	}
	return result;

}
