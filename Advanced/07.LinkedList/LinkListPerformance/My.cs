using System.Diagnostics;
using ConsoleApp1;

int n = 5000000;
Stopwatch watch = Stopwatch.StartNew();

LinkedList<int> linkedList = new LinkedList<int>();
for (int i = 0; i < n; i++)
{
    linkedList.AddFirst(i);
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);
watch =  Stopwatch.StartNew();
MyLinkedList myList =  new MyLinkedList();
for (int i = 0; i < n; i++)
{
    linkedList.AddFirst(i);
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);