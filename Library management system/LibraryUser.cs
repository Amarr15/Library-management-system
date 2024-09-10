using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class LibraryUser : User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard Card { get; set; }

        public void Borrowbook(Book book, Library library)
        {
            library.BorrowBook(book);
        }
    }
}
