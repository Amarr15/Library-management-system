namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcone To The Library System (:");
            Library library = new Library();
            Console.WriteLine("Are You Librarian or Reguler User? (L / R)");
            Console.WriteLine("Please Choose (L (Librarian) / R (Reguler User) )");
            char UserType = Console.ReadLine().ToUpper()[0];//Because we will receive a string from the user, we will take the first letter, whether he entered a string or a letter.



            if (UserType == 'L')
            {
                Console.WriteLine("Please Enter Your Name: ");
                string LibrarianName = Console.ReadLine();
                Librarian l1 = new Librarian(LibrarianName);
                Console.WriteLine($"Welcome {l1.Name} (:");
                while (true)
                {
                    Console.WriteLine("Please Enter Choise To Add Book (A) / Remove Book (R) / Display Book (D)");
                    char choise = Console.ReadLine().ToUpper()[0];
                    switch (choise)
                    {
                        case 'A':
                            Console.WriteLine("Enter Book Details");
                            Console.WriteLine("Enter Book Name");
                            string bookName = Console.ReadLine();
                            Console.WriteLine("Enter Author Name");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter The Year");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            l1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter Book Details");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            l1.RemoveBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("The List Book: ");
                            l1.Displaybooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if (UserType == 'R')
            {
                Console.WriteLine("Welcome User, Enter Your Name: ");
                Console.WriteLine("Please Enter Your Name: ");
                string name = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(name);
                Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {
                    Console.WriteLine("Please Enter Choise To Display Book (D) or Borrow Book (B) ");
                    char choise = Console.ReadLine().ToUpper()[0];
                    switch (choise)
                    {
                        case 'D':
                            Console.WriteLine("The List Book: ");
                            u1.Displaybooks(library);
                            break;

                        case 'B':
                            Console.WriteLine("Enter Book Details To Borrow");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear,
                            };
                            u1.Borrowbook(book, library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct Value (L or R)");
            }
        }
    }
}
