using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSoloImplementation
{
    public class LinkedList
    {
        private bool reversed = false;
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void AddLast(int value)
        {
            Count++;
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }

        public void AddFirst(int value)
        {
            Count++;

            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }

            Head.Previous = newNode;
            newNode.Next = Head;
            Head = newNode;
        }

        public Node RemoveFirst()
        {
            Node nodeToRemove = Head;
            if (Head == null)
            {
                Console.WriteLine("Empty list");
                return null;
            }

            Count--;

            Head = Head.Next;
            nodeToRemove.Next = null;
            Head.Previous = null;

            return nodeToRemove;
        }

        public Node RemoveLast()
        {
            Node nodeToRemove = Tail;
            if (Tail == null)
            {
                Console.WriteLine("Empty list");
                return null;
            }


            Tail = Tail.Previous;
            nodeToRemove.Previous = null;
            Tail.Next = null;
            Count--;

            return nodeToRemove;
        }

        public void ForEach(Action<int> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            Node currentNode = Head;
            int count = 0;
            while (currentNode != null)
            {
                array[count] = currentNode.Value;
                currentNode = currentNode.Next;
                count++;
            }

            return array;
        }

        public void Reverse()
        {
            Node currentNode = Head;
            Node prev = null;
            Node next = null;
            while (currentNode != null)
            {
                next = currentNode.Next;
                currentNode.Previous = next;
                currentNode.Next = prev;

                prev = currentNode;
                currentNode = next;
            }

            Tail = Head;
            Head = prev;
        }
    }
}