using System;
using System.Collections.Generic;
using System.Text;
public class Reader
{
    public string Name { get; set; }
    public int Id { get; set; }
    private List<Book> _borrowedBooks = new List<Book>();

    public Reader(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public void BorrowBook(Book book)
    {
        _borrowedBooks.Add(book);
        Console.WriteLine($"{Name} взял книгу \"{book.Title}\"");
    }

    public void ShowBorrowedBooks()
    {
        Console.WriteLine($"Книги у {Name}:");
        foreach (var book in _borrowedBooks)
        {
            book.ShowInfo();
        }
    }
}