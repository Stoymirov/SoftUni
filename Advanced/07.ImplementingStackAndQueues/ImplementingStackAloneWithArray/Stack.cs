using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStackAloneWithArray
{
    public class Stack
    {
        private int[] items;
        private int InitialLength = 4;
       public Stack()
        {
            items = new int[4];
        }
        public int Count { get; private set; }

        public int Pop()

        {
            Validate();
            if (Count == items.Length / 4)
            {
                Shrink();
            }
            Count--;
            int itemToReturn = items[Count];
            items[Count] = default;// this is unnecessary because decreasing the count will not allow to get access to this element
            return itemToReturn;
        }
        public void Push(int item)
        {
            if(items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }
        public int Peek()
        {
            Validate();
            return items[Count - 1];
        }
        public void Foreach(Action<int> action)
        {
            for(int i = 0; i < Count; i++)
            {
                action(items[i]);
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
            if(Count ==0)
            {
                throw new InvalidOperationException();
            }
        }




    }
}
