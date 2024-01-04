using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private int index;
        private List<T> _items;

        public ListyIterator(List<T> items)
        {
            _items = items;
        }
        public bool Move()
        {
            if (index < _items.Count - 1)
            {
                index++;
                return true;
            }
            
            return false;
        }

        public bool HasNext()
        {
            if (index < _items.Count - 1)
                return true;
            return false;
        }

        public void Print()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Invalid operation!");
            }

            Console.WriteLine(_items[index]);
        }

       

        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
            //foreach (var item in _items)
            //{
            //    yield return item;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
