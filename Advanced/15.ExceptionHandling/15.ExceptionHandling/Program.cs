try
{
    int age = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("tova ne e chislo");
}
catch(OverflowException)
{
    Console.WriteLine("tova e tvyrdo big");
}