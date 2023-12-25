using System.Xml.XPath;
using Microsoft.VisualBasic;

//method taking the current result the operand and the operation function, then in the method perform the function with the paramethers. So first create a func which takes two numbers and gives a number as input;
int result = 0;
while (true)
{
    Console.WriteLine("Operation:");
    string operationType = Console.ReadLine();

    Console.WriteLine("Value:");
    int operand = int.Parse(Console.ReadLine());

    Func<int, int, int> operation = OperationMethod(operationType);

    Func<int, int, int> OperationMethod(string operationType)
    {
        switch (operationType)
        {
            case "+": return (x, y) => x + y;
            case "-": return (x, y) => x - y;
            case "*": return (x, y) => x * y;
            case "/": return (x, y) => x / y;
            default:
                break;
        }

        return null;
    }

    result = Calculate(operand, result, operation);
    Console.WriteLine(result);

    int Calculate(int i, int result1, Func<int, int, int> func)
    {
        Console.WriteLine($"Performing operations on {i} and {result1}");
        return func(i, result);
    }
}