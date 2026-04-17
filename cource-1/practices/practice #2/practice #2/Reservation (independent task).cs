using System;
using System.Collections.Generic;
using System.Text;
public class Reservation
{
    public Book ReservedBook { get; }
    public Reader ReservedBy { get; }
    public DateTime ReservationDate { get; }
    public int ExpiryDays { get; }

    public Reservation(Book book, Reader reader, int expiryDays = 3)
    {
        ReservedBook = book;
        ReservedBy = reader;
        ReservationDate = DateTime.Now;
        ExpiryDays = expiryDays;
    }

    public bool IsExpired()
    {
        return DateTime.Now > ReservationDate.AddDays(ExpiryDays);
    }
}