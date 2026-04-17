using System;
using System.Collections.Generic;
using System.Text;

public class Textbook : Book
{
    public string Subject { get; set; }

    public Textbook(string title, string author, int year, int pages, string subject)
        : base(title, author, year, pages)
    {
        Subject = subject;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Учебник: {Title}, Предмет: {Subject}, Автор: {Author}, Год: {Year}, Страниц: {Pages}");
    }
}