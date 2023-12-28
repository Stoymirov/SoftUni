using System.Threading.Channels;
using ConsoleApp1;


MyLinkedList linkedList = new MyLinkedList();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddFirst(0);
linkedList.AddFirst(-1);
linkedList.Reverse();
linkedList.ForEach(x=>Console.WriteLine($"From foreach: {x}"));



Console.WriteLine($"Head {linkedList.Head}");
Console.WriteLine($"Tail {linkedList.Tail}");
Node currentNode = linkedList.Head;
while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next;
}

Console.WriteLine(string.Join(" ",linkedList.ToArray()));
//Node head= new Node(1);
//head.Next =new Node(2);
//head.Next.Next =new Node(3);
//head.Next.Next.Next =new Node(4);
//head.Next.Next.Next.Next = new Node(5);