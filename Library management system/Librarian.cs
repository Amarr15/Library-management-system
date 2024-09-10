using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Librarian : User
    {
        public Librarian(string name)
        {
            Name = name;
        }
        public int EmployeeNumber { get; set; }

        public void AddBook(Book newbook, Library library)
        {
            library.Add(newbook);//assoiation
        }
        public void RemoveBook(Book newbook, Library library)
        {
            library.Remove(newbook);//assoiation
        }
    }
}
