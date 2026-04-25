using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
//steps 2-6
var books = new List<Book>
{
    new Book { Title = "War and Peace", Author = "Tolstoy", Year = 1869 },
    new Book { Title = "Crime and Punishment", Author = "Dostoevsky", Year = 1866 }
};

var options = new JsonSerializerOptions { WriteIndented = true };
File.WriteAllText("books.json", JsonSerializer.Serialize(books, options));

var booksFromFile = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("books.json"));

foreach (var book in booksFromFile)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
}

// steps 8-11
var library = new Library
{
    Name = "City Library",
    Books = new List<Book>
    {
        new Book { Title = "War and Peace", Author = "Tolstoy", Year = 1869 },
        new Book { Title = "Crime and Punishment", Author = "Dostoevsky", Year = 1866 }
    }
};

File.WriteAllText("library.json", JsonSerializer.Serialize(library, options));

var libraryFromFile = JsonSerializer.Deserialize<Library>(File.ReadAllText("library.json"));

Console.WriteLine($"\nLibrary: {libraryFromFile.Name}");
foreach (var b in libraryFromFile.Books)
{
    Console.WriteLine($"Book: \"{b.Title}\", Author: {b.Author}, Year: {b.Year}");
}