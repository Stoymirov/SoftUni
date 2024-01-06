using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            string[] array = new[] { "2", "3", "4" };
            stack.AddRange(array);

            foreach (var stackOfString in stack)
            {
                Console.WriteLine(stackOfString);
            }
        }
    }
}