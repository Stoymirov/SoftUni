using ImplementingStackAloneWithArray;

Stack stack = new Stack();
stack.Push(2);
stack.Push(3);
    stack.Push(4);
    stack.Push(5);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());

int sum = default;
stack.Foreach(x=>sum+=x);
Console.WriteLine(sum);
stack.Peek();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();

