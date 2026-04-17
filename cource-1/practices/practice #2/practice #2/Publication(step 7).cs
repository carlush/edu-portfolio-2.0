using System;
using System.Collections.Generic;
using System.Text;
public abstract class Publication
{
    public abstract void GetInfo();
}

public class BookPublication : Publication
{
    private Book _book;

    public BookPublication(Book book)
    {
        _book = book;
    }

    public override void GetInfo()
    {
        _book.ShowInfo();
    }
}

