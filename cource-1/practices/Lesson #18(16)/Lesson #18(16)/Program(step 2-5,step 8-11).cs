using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // step 2
        var books = new List<Book>
        {
            new Book { Title = "War and Peace", Author = "Lev Tolstoy", Year = 1869 },
            new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866 }
        };

        var options = new JsonSerializerOptions { WriteIndented = true };

        // step 3
        using (FileStream writeStreambook = File.Create("books.json"))
        {
            await JsonSerializer.SerializeAsync(writeStreambook, books, options);
        }

        // step 4
        List<Book> booksFromFile;
        using (FileStream readStreambook = File.OpenRead("books.json"))
        {
            booksFromFile = await JsonSerializer.DeserializeAsync<List<Book>>(readStreambook);
        }

        // step 5
        Console.WriteLine("--- Books ---");
        foreach (var book in booksFromFile)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }

        Console.WriteLine("\n--- Library ---");

        // step 8
        var library = new Library
        {
            Name = "City Library",
            Books = new List<Book>
            {
                new Book { Title = "War and Peace", Author = "Lev Tolstoy", Year = 1869 },
                new Book { Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866 }
            }
        };

        // step 9
        using (FileStream writeStreamlib = File.Create("library.json"))
        {
            await JsonSerializer.SerializeAsync(writeStreamlib, library, options);
        }

        // step 10
        Library libraryFromFile;
        using (FileStream readStreamlib = File.OpenRead("library.json"))
        {
            libraryFromFile = await JsonSerializer.DeserializeAsync<Library>(readStreamlib);
        }

        // step 11
        Console.WriteLine($"Library: {libraryFromFile.Name}");
        foreach (var b in libraryFromFile.Books)
        {
            Console.WriteLine($"Book: \"{b.Title}\", Author: {b.Author}, Year: {b.Year}");
        }
    }
}