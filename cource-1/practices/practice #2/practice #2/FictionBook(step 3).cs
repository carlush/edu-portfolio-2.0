using System;
using System.Collections.Generic;
using System.Text;

public class FictionBook : Book
{
    public string Genre { get; set; }

    public FictionBook(string title, string author, int year, int pages, string genre)
        : base(title, author, year, pages)
    {
        Genre = genre;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Художественная книга: {Title}, Жанр: {Genre}, Автор: {Author}, Год: {Year}, Страниц: {Pages}");
    }
}