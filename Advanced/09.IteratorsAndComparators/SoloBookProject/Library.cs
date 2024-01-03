using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library:IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = this.books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(List<> books)
            {
                
            }
            public void Dispose()
            {
                // TODO release managed resources here
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex == books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public Book Current
            {
                get { return this.books[currentIndex]; }
            }

            object IEnumerator.Current => Current;
        }
    }
}
