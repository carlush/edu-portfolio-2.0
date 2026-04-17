//#1
//public abstract class Shape
//{
//    public abstract string Name { get; }
//    public abstract double GetArea();
//    public void Print()
//    {
//        Console.WriteLine($"{Name}: площадь = {GetArea()}");
//    }
//}
//public class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }
//    public override string Name => "Круг";
//    public override double GetArea()
//    {
//        return Math.PI * Math.Pow(Radius, 2);
//    }
//}
//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }
//    public override string Name => "Прямоугольник";
//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Shape[] shapes = new Shape[]
//        {
//            new Circle(10),
//            new Rectangle(5, 8),
//            new Circle(2.5),
//            new Rectangle(12, 12)
//        };

//        Console.WriteLine("--- Список фигур и их площади ---");
//        foreach (Shape shape in shapes)
//        {
//            shape.Print();
//        }
//    }
//}
//#2
//public abstract class Animal
//{
//    public string Name { get; set; }

//    protected Animal(string name)
//    {
//        Name = name;
//        Console.WriteLine($"Создано животное по имени {Name}");
//    }
//    public void Eat()
//    {
//        Console.WriteLine($"{Name} ест.");
//    }
//    public abstract void MakeSound();
//}
//public class Dog : Animal
//{
//    public Dog(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name}: Гав-гав!");
//    }
//}
//public class Cat : Animal
//{
//    public Cat(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name}: Мяу!");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal[] animals = new Animal[]
//        {
//                new Dog("Рекс"),
//                new Cat("Мурка")
//        };
//        foreach (Animal animal in animals)
//        {
//            animal.Eat();
//            animal.MakeSound();
//            Console.WriteLine();
//        }
//    }
//}
//#3
//public abstract class Transport
//{
//    public void Move()
//    {
//        Start();
//        MoveCore();
//        Stop();
//    }

//    protected void Start() => Console.WriteLine("Транспорт начинает движение");
//    protected abstract void MoveCore();
//    protected void Stop() => Console.WriteLine("Транспорт останавливается");
//}
//public class Car : Transport
//{
//    protected override void MoveCore() => Console.WriteLine("Машина едет по дороге");
//}

//public class Boat : Transport
//{
//    protected override void MoveCore() => Console.WriteLine("Лодка плывёт по воде");
//}
//public class Programm
//{
//    static void Main ()
//    {
//        Transport[] t = { new Car(), new Boat() };
//        foreach (var x in t) x.Move();
//    }
//}
//#4
//public abstract class DocumentExporter
//{
//    public abstract string FormatName { get; }
//    public abstract void Export(string content);
//    public void ShowInfo(string content)
//    {
//        Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
//    }
//}
//public class TxtExporter : DocumentExporter
//{
//    public override string FormatName => "TXT";

//    public override void Export(string content)
//    {
//        Console.WriteLine("Сохраняем текстовый файл...");
//        ShowInfo(content);
//    }
//}
//public class PdfExporter : DocumentExporter
//{
//    public override string FormatName => "PDF";

//    public override void Export(string content)
//    {
//        Console.WriteLine("Создаём PDF-документ...");
//        ShowInfo(content);
//    }
//}
//public class Program
//{
//    static void Main()
//    {
//        DocumentExporter[] exporters =
//        {
//    new TxtExporter(),
//    new PdfExporter()
//};

//        foreach (var e in exporters)
//        {
//            e.ShowInfo("Hello world!");
//            e.Export("Hello world!");
//        }
//    }
//}