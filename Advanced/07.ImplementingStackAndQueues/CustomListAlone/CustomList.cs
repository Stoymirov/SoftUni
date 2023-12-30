using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomListAlone
{
    public class CustomList
    {
        private int[] items;
        private int initialSize = 2;

        public CustomList()
        {
            items = new int[initialSize];
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


        public void Add(int numberToAdd)
        {

            if (Count == items.Length)
            {
                Resize();
            }
            items[Count] = numberToAdd;
            Count++;

        }

        public void InsertAt(int index, int numberToAdd)
        {
            ValidateIndex(index);
            if (Count == items.Length)
            {
                Resize();
            }
            ShiftRight(index);

            items[index] = numberToAdd;

            Count++;
        }
        public int RemoveAt(int index)
        {
            ValidateIndex(index);
            ShiftLeft(index);
            Count--;
            if (Count <= items.Length / 4)
                Shrink();
            return items[index];
        }

        public bool Contains(int number)

        {
            bool found = default;
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == number)
                {
                    found = true;
                }
            }
            return found;
        }

        public void Swap(int index, int index2)
        {
            ValidateIndex(index);
            ValidateIndex(index2);
            (items[index], items[index2]) = (items[index2], items[index]);
        }
        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
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

        private void Shrink()
        {
            int[] newArray = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
    }
}
