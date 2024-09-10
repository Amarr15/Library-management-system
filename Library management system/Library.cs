using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookCount = 0;
        private Book[] Borrowedbooks = new Book[50];
        private int currentBorrowedBooksCount = 0;

        public void display()
        {
            for (int i = 0; i < currentBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book Added Succesufely");
            }
            else
            {
                Console.WriteLine("Library is full,Can't Add New Book");
            }
        }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBookCount--;
            Console.WriteLine("Book Removed");
        }

        public void BorrowBook(Book book)
        {
            if (currentBorrowedBooksCount < Borrowedbooks.Length)
            {
                Borrowedbooks[currentBorrowedBooksCount] = book;
                currentBookCount++;
                Console.WriteLine("Book Borowed Succesufely");
            }
            else
            {
                Console.WriteLine("Sorry, can't Borrow More");
            }
        }
    }
}
