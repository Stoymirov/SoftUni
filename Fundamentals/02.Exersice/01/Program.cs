var input = Console.ReadLine();
while (input !="END")
{
    if (int.TryParse(input, out int integerNumber))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out double doubleNumber))
    {
        Console.WriteLine(($"{input} is floating point type"));
    }
    else if (bool.TryParse(input, out bool boolNumber))
    {
        Console.WriteLine(($"{input} is boolean type"));

    }
    else if (char.TryParse(input, out char charNumber))
    {
        Console.WriteLine(($"{input} is character type"));

    }
    else
        Console.WriteLine(($"{input} is string type"));
    input = Console.ReadLine();
}