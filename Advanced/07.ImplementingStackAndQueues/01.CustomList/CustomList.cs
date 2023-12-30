using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.CustomList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            items = new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set
            {
                ValidateIndex(index);
                items[index] = value;
            }
        }


        public void Add(int item)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }

        public int Remove(int index)
        {
            ValidateIndex(index);
            
            int removedItem = items[index];
            items[index] = default;
            ShiftLeft(index);
            Count--;
            return removedItem;
        }



        private void Resize()
        {
            int[] copy= new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];

            }

            items = copy;
        }
        private void ValidateIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void ShiftLeft( int index)
        {
            for (int i = index; i < Count-1; i++)
            {
                items[i] = items[i+1];
            }
        }



    
    }
}
