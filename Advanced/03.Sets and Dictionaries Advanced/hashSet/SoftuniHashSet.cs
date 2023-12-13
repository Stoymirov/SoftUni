using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hashSet
{
    internal class SoftuniHashSet
    {
        private List<string>[] internalArray;
        private int count = 0;

        public SoftuniHashSet()
        {
            internalArray = new List<string>[8];
        }

        public void Add(string element)
        {
            int index = HashFunction(element,internalArray.Length);
            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
            }
            internalArray[index].Add(element);

            if (count / (float)internalArray.Length * 100 > 60)
            {
                Resize();
            }

            count++;
        }

        private void Resize()
        {
            var newArray = new List<string>[internalArray.Length*2];
            for (int i = 0; i < internalArray.Length; i++)
            {
                if (internalArray[i] != null)
                {
                    for (int j = 0; j < internalArray[i].Count; j++)
                    {
                        string elementToReHash = internalArray[i][j];
                        int index = HashFunction(elementToReHash, newArray.Length);
                        if (newArray[index] == null)
                        {
                            newArray[index] = new List<string>();
                        }
                        newArray[index].Add(elementToReHash);
                    }
                }
            }

            internalArray = newArray;
        }

        public bool Contains(string element)
        {
            int index = HashFunction(element,internalArray.Length);
            if (internalArray[index] != null)
            {
                for (int i = 0; i < internalArray[index].Count; i++)
                {
                    if (internalArray[index][i] == element)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int HashFunction(string element,int count)
        {
            
            int sum = element[0] + element[1] + element[2];
            return sum%count;
        }
    }
}
