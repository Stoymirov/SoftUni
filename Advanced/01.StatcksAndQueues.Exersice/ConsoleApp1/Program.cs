using System.Security.Cryptography.X509Certificates;

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = 
    new Stack<int>(input.Take(array[1]));

if (stack.Contains(array[2]))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
    Console.WriteLine(0);
else Console.WriteLine(stack.Min());