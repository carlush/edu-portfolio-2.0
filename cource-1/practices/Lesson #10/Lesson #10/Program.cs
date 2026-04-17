//Первое задание
//public class Car
//{
//    public string Brand { get; set; }
//    public int Speed { get; set; } = 120;
//    public void Accelerate()
//    {
//        Speed += 25;
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        var car = new Car { Brand = "Mercedes" };
//        car.Accelerate();

//        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
//    }
//}

//Второе задание
//public class Car
//{
//    public string Brand { get; }
//    public int Speed { get; private set; }
//    public Car(string brand, int speed)
//    {
//        Brand = brand;
//        Speed = speed;
//    }
//    public void Accelerate()
//    {
//        Speed += 10;
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        var car = new Car("Audi", 50);

//        car.Accelerate();
//        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
//    }
//}

// Третье задание
//var myLibrary = new Library();
//var book1 = new Book("1984", "Джордж Оруэлл", 328);
//var book2 = new Book("Мастер и Маргарита", "Михаил Булгаков", 480);
//myLibrary.AddBook(book1);
//myLibrary.AddBook(book2);
//book1.Read(50);
//myLibrary.PrintAllBooks();
//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Pages { get; set; }

//    public Book(string title, string author, int pages)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//    }

//    public void Read(int pagesRead)
//    {
//        if (pagesRead > Pages)
//        {
//            pagesRead = Pages;
//        }

//        Console.WriteLine($"Вы прочитали {pagesRead} страниц из {Pages} в книге \"{Title}\"");
//    }
//}
//public class Library
//{
//    private List<Book> books = new List<Book>();
//    public void AddBook(Book book)
//    {
//        books.Add(book);
//        Console.WriteLine($"Книга \"{book.Title}\" добавлена в библиотеку.");
//    }
//    public void PrintAllBooks()
//    {
//        Console.WriteLine("\n--- Список книг в библиотеке ---");
//        foreach (var book in books)
//        {
//            Console.WriteLine($"{book.Author} — \"{book.Title}\" ({book.Pages} стр.)");
//        }
//    }
//}
