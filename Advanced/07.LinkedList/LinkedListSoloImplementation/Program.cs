using System.Threading.Channels;
using LinkedListSoloImplementation;

LinkedList linkedList = new LinkedList();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.AddLast(4);
linkedList.AddFirst(0);

Node currentNode = linkedList.Head;
while(currentNode!=null)
{
    Console.WriteLine(currentNode);
    currentNode = currentNode.Next;
}
linkedList.RemoveFirst();
Console.WriteLine(linkedList.Head);

int sum = 0;
linkedList.ForEach(x=>sum+=x);
Console.WriteLine(sum);

Console.WriteLine(string.Join("wtf ",linkedList.ToArray()));
linkedList.Reverse();
Console.WriteLine(string.Join("wtf ", linkedList.ToArray()));




