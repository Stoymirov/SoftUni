using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T>:IEnumerable<T>
    {

        private T[] _array;
        private int initialCapacity = 4;
        public int Count { get; set; }
        public CustomStack()
        {
            _array = new T[initialCapacity];
        }


        public void Push(T element)
        {
            if (Count == _array.Length)
            {
                Resize();
            }
            _array[Count] = element;
            Count++;
        }


        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            Count--;
            return _array[Count];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i =  Count- 1; i >= 0; i--)
            {
                yield return _array[i];
            }
        }
        private void Resize()
        {
            T[] newArray = new T[_array.Length*2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
