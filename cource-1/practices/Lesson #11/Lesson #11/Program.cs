using System.Runtime.ConstrainedExecution;

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Pages { get; set; }
//    public Book()
//    {
//        Title = "Война и мир";
//        Author = "Лев Николаевич Толстой";
//        Pages = 1408;
//    }
//    public Book(string title) : this()
//    {
//        Title = title;
//    }
//    public Book(string title, string author) : this(title)
//    {
//        Title = title;
//        Author = author;
//    }
//    public Book(string title, string author, int pages) : this(title, author)
//    {
//        Pages = pages;
//    }
//    public void PrintInfo()
//    {
//        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
//    }
//}
//public class Program
//{
//    public static void Main()
//    {
//        var b1 = new Book();
//        var b2 = new Book("1984", "Дж. Оруэлл", 200);
//        var b3 = new Book("Гарри Поттер", "Дж. Роулинг", 500);

//        b1.PrintInfo();
//        b2.PrintInfo();
//        b3.PrintInfo();
//    }
//}
// #2
//public class Car
//{
//    public string Brand { get; set; }
//    public int Speed { get; set; }
//    public string Model { get; set; }
//    public Car() : this("Unknown Brand", "Unknown Model")
//    {

//    }
//    public Car(string brand) : this(brand, "Unknown Model")
//    {
//    }
//    public Car(string brand, string model)
//    {
//        Brand = brand;
//        Model = model;
//        Speed = 80;
//    }
//    public void PrintInfo()
//        {
//            Console.WriteLine($"Авто: {Brand} {Model}, Скорость: {Speed} км/ч");
//        }
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Car car1 = new Car();
//            Car car2 = new Car("Lamborgini");
//            Car car3 = new Car("BMW", "X5");
//            car1.PrintInfo();
//            car2.PrintInfo();
//            car3.PrintInfo();
//        }
//    }
//}
//#3
//namespace GameApp
//{
//    public class Player
//    {
//        public string Name { get; set; }
//        public int Level { get; set; }

//        public Player(string name, int level)
//        {
//            Name = name;
//            Level = level;
//        }

//        public void PrintInfo()
//        {
//            Console.WriteLine($"Игрок: {Name}, Уровень: {Level}");
//        }
//        public override bool Equals(object obj)
//        {
//            if (obj is Player other)
//            {
//                return this.Name == other.Name && this.Level == other.Level;
//            }
//            return false;
//        }
//        public override int GetHashCode()
//        {
//            return HashCode.Combine(Name, Level);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var p1 = new Player("Alex", 5);
//            var p2 = new Player("Alex", 5);
//            var p3 = p1;
//            Console.WriteLine(p1 == p2);
//            Console.WriteLine(p1 == p3); 
//            Console.WriteLine(p1.Equals(p2));

//            Console.ReadKey();
//        }
//    }
//}
//#4
//namespace UserApp
//{
//    public class User
//    {
//        public string Login { get; set; }
//        private string password;
//        public string Password
//        {
//            get { return password; }
//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                {
//                    password = value;
//                    Console.WriteLine("Пароль обновлен");
//                }
//                else
//                {
//                    Console.WriteLine("Ошибка: Пароль не может быть пустым!");
//                }
//            }
//        }
//        public bool CheckPassword(string input)
//        {
//            return password == input;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var user = new User { Login = "admin" };
//            user.Password = "12345";
//            Console.WriteLine($"Результат проверки 12345: {user.CheckPassword("12345")}");

//            user.Password = "";
//            Console.WriteLine($"Текущий пароль всё еще 12345? {user.CheckPassword("12345")}");

//            Console.ReadKey();
//        }
//    }
//}
//#5
//namespace PointApp
//{
//    public class Point
//    {
//        public int X { get; set; }
//        public int Y { get; set; }

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }
//        public void Move(int dx, int dy)
//        {
//            X += dx;
//            Y += dy;
//        }

//        public void PrintInfo(string name)
//        {
//            Console.WriteLine($"{name}: X = {X}, Y = {Y}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point p1 = new Point(10, 10);
//            p1.PrintInfo("p1 (старт)");
//            Point p2 = p1;
//            p2.Move(5, -3);
//            Console.WriteLine("\n--- После изменения p2 ---");
//            p2.PrintInfo("p2");
//            p1.PrintInfo("p1");

//            Console.WriteLine("\nИзменился ли p1? " + (p1.X == p2.X && p1.Y == p2.Y));

//            Console.ReadKey();
//        }
//    }
//}