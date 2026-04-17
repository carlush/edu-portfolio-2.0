using System;
using System.Collections.Generic;
using System.Text;
public class Library : ILibraryManagement
{
    private List<Book> _books = new List<Book>();
    private List<Reservation> _reservations = new List<Reservation>();
    public void AddBook(Book book) => _books.Add(book);

    public bool RemoveBook(Book book) => _books.Remove(book);

    public List<Book> SearchByAuthor(string author) =>
        _books.Where(b => b.Author == author).ToList();

    public void ListBooks()
    {
        Console.WriteLine("\n--- Книги в наличии ---");
        foreach (var book in _books) book.ShowInfo();
    }

    public void ReserveBook(Book book, Reader reader)
    {
        if (!_books.Contains(book))
        {
            Console.WriteLine($"Ошибка: Книги \"{book.Title}\" нет в наличии для брони.");
            return;
        }

        if (_reservations.Any(r => r.ReservedBook == book))
        {
            Console.WriteLine($"Книга \"{book.Title}\" уже забронирована.");
            return;
        }

        _reservations.Add(new Reservation(book, reader));
        Console.WriteLine($"Книга \"{book.Title}\" зарезервирована для {reader.Name}.");
    }

    public void CancelReservation(Book book)
    {
        var res = _reservations.FirstOrDefault(r => r.ReservedBook == book);
        if (res != null)
        {
            _reservations.Remove(res);
            Console.WriteLine($"Бронь на книгу \"{book.Title}\" отменена.");
        }
    }

    public void IssueBook(Book book, Reader reader)
    {
        if (!_books.Contains(book))
        {
            Console.WriteLine($"Книга \"{book.Title}\" отсутствует.");
            return;
        }
        var reservation = _reservations.FirstOrDefault(r => r.ReservedBook == book);

        if (reservation != null)
        {
            if (reservation.IsExpired())
            {
                _reservations.Remove(reservation);
            }
            else if (reservation.ReservedBy != reader)
            {
                Console.WriteLine($"Отказ: Книга \"{book.Title}\" зарезервирована пользователем {reservation.ReservedBy.Name}.");
                return;
            }
            else
            {
                _reservations.Remove(reservation);
            }
        }

        reader.BorrowBook(book);
        _books.Remove(book);
    }

    public void ReturnBook(Book book)
    {
        _books.Add(book);
        Console.WriteLine($"Книга \"{book.Title}\" возвращена.");
    }
}


