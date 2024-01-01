//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BoxOfT
//{
//    public class BoxArray<T>
//    {
//        public int Count { get; private set; }
//        private T[] array;

//        public BoxArray()
//        {
//            array = new T[4];
//        }

//        public void Add(T element)
//        {
//            if (Count == array.Length)
//            {
//                Grow();
//            }
//            array[Count++] = element;

//        }
//        // 1 2 0 0 0 0 0
//        public T Remove()
//        {
//            T element = array[Count - 1];
//            array[Count-- -1] = default;
//            if (Count == array.Length / 4)
//            {
//                Shrink();
//            }
//            return element;
//        }

//        private void Grow()
//        {
//            T[] newArray = new T[array.Length*2];
//            for (int i = 0; i < array.Length; i++)
//            {
//                newArray[i] = array[i];
//            }
//            array = newArray;
//        }

//        private void Shrink()
//        {
//            T[] newArray = new T[array.Length / 2];
//            for (int i = 0; i < Count; i++)
//            {
//                newArray[i] = array[i];
//            }

//            array = newArray;

//        }

//    }
//}
