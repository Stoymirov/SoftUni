object[] array = Console.ReadLine().Split();
int sum = 0;
foreach (var o in array)
{
    try
    {
       int parsed = int.Parse((string)o);
        sum+=parsed;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{o}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{o}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{o}' processed - current sum: {sum}");
    }
}

Console.WriteLine("The total sum of all integers is: {0}",sum);