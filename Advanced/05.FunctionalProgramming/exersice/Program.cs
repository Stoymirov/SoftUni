using System.Dynamic;
using System.Xml.XPath;
int result = 0;
while (true)
{
    Console.WriteLine("Operation:");
    string operationType = Console.ReadLine();

    Console.WriteLine("Value: ");
    int operand = int.Parse(Console.ReadLine());

    Func<int, int, int> operation = GetOperation(operationType);

    result = Calculate(operation, operand, result);
    Console.WriteLine(result);

    int Calculate(Func<int, int, int> func, int operand, int result)
    {
        return func(result, operand);
    }

    Func<int, int, int> GetOperation(string operationType)
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
}