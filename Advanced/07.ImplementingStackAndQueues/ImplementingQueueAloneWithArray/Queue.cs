using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueueAloneWithArray
{
    public class Queue
    {
       
            private int[] items;
            private const int InitialLength = 4;
            private const int FirstElementIndex = 0;
            public Queue()
            {
                items = new int[4];
            }
            public int Count { get; private set; }

            public int Dequeue()

            {
                Validate();
                if (Count == items.Length / 4)
                {
                    Shrink();
                }//optional
                Count--;
                int itemToReturn = items[FirstElementIndex];
                items[FirstElementIndex] = default;// this is unnecessary because decreasing the count will not allow to get access to this element
            ShiftLeft();
                return itemToReturn;
            } 
            public void Enqueue(int item)
            {
                if (items.Length == Count)
                {
                    Resize();
                }
                items[Count] = item;
                Count++;
            }
            public int Peek()
            {
                Validate();
                return items[0];
            }
            public void Foreach(Action<int> action)
            {
                for (int i = 0; i < Count; i++)
                {
                    action(items[i]);
                }
            }

            public void Clear()
            {
                items = new int[InitialLength];

                Count = 0;
            }
            private void ShiftLeft()
            {
                for (int i = 0; i < Count; i++)
                {
                    items[i] = items[i + 1];
                }
            }
        private void Shrink()
            {
                int[] newArray = new int[items.Length / 2];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }
            private void Resize()
            {
                int[] newArray = new int[items.Length * 2];

                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;

            }
            private void Validate()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException();
                }
            }




        }
    }




