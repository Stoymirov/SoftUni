int n = 0;


try
{
    n = int.Parse(Console.ReadLine());
    if (n < 0)
    {
        throw new ArgumentException("Invalid number.");
    }
    Console.WriteLine(Math.Sqrt(n));
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);

}
finally
{
    Console.WriteLine("Goodbye.");
}