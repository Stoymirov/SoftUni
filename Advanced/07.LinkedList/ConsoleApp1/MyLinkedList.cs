using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyLinkedList
    {
        private bool isReversed = false;
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void AddLast(int nodeValue)
        {
            Count++;
            Node newNode = new Node(nodeValue);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void AddFirst(int nodeValue)
        {
            Count++;
            Node node = new Node(nodeValue);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }

        public Node RemoveLast()
        {
            Node nodeToRemove = Tail;

            Tail = Tail.Previous;
            Tail.Next = null;
            nodeToRemove.Previous = null;
            Count--;
            return nodeToRemove;
        }

        public Node RemoveFirst()
        {
            Node noteToRemove = Head;
            Head = Head.Next;
            Head.Previous = null;
            noteToRemove.Next = null;
            Count--;
            ; return noteToRemove;
        }

        public void ForEach(Action<int> callback)
        {
            Node currentNode = null;
            if (isReversed)
            {
                currentNode = Tail;
            }
            else
            {
                currentNode = Head;
            }

            while (currentNode != null)
            {
                callback(currentNode.Value);
                currentNode = isReversed ? currentNode.Previous : currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            ForEach(x => array[index++] = x);
            return array;
        }

        public void Reverse()
        {
            isReversed = !isReversed;
        }
    }
}
