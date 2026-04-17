using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Library library = new Library();

        Textbook t1 = new Textbook("Математика 101", "Иванов", 2020, 300, "Математика");
        FictionBook f1 = new FictionBook("Война и мир", "Толстой", 1869, 1200, "Роман");

        library.AddBook(t1);
        library.AddBook(f1);
        library.ListBooks();

        Reader reader1 = new Reader("Алексей", 1);
        Reader reader2 = new Reader("Мария", 2);

        library.ListBooks();

        library.ReturnBook(t1);
        library.ReturnBook(f1);
        library.ListBooks();

        Publication pub = new BookPublication(f1);
        pub.GetInfo();

        library.ReserveBook(f1, reader1);
        library.IssueBook(f1, reader2);
        library.IssueBook(f1, reader1);

        reader1.ShowBorrowedBooks();
        library.ListBooks();
    }
}