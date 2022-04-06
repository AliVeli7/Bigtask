using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Library
    {
        public int BookLimit;
        public Book[] books = new Book[1];

        public void AddBook(Book book)
        {
            books[books.Length - 1] = book;
            Array.Resize(ref books, books.Length + 1);
        }

       


        public void GetBookById(int? id)
        {
            if (!(id is null))
            {
                if (!(books[(int)id - 1] is null))
                {
                    Console.WriteLine((books[(int)id - 1].Name));
                }

            }

        }


        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

    }
}
