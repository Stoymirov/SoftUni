using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;

    public class Library:IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
        this.books = new List<Book>(books);
    }
        public IEnumerator<Book> GetEnumerator()
        {
            //foreach (var book in books)
            //{
            //    yield return book;
            //}
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class LibraryIterator:IEnumerator<Book>
        {
            private int index = -1;
            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = new List<Book>(books);
                this.books.Sort(new BookComparator());
            }
            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                return ++index < books.Count;
            }

            public void Reset()
            {
                index = -1;
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;
        }
    }

