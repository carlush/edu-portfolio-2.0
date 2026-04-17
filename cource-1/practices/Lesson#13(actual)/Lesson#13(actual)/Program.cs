//#1
//public class animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издаёт звук.");
//    }
//}
//public class Dog : animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Собака говорит: Гав-гав!");
//    }
//}

//public class Cat : animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Кошка говорит: Мяу!");
//    }
//}

//public class Cow : animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Корова говорит: Муу!");
//    }
//}
//public class Program
//{
//    static void Main()
//    {
//        animal dog = new Dog();
//        animal cat = new Cat();
//        animal cow = new Cow();

//        dog.Speak();
//        cat.Speak();
//        cow.Speak();
//    }
//}
//#2
//public class Transport
//{
//    public string Model { get; set; }

//    public virtual void Move()
//    {
//        Console.WriteLine($"{Model}: транспорт движется.");
//    }
//}
//public class Car : Transport
//{
//    public override void Move()
//    {
//        base.Move();
//        Console.WriteLine($"Машина едет по дороге.");
//    }
//}
//public class Boat : Transport
//{
//    public override void Move()
//    {
//        Console.WriteLine($"{Model}: транспорт движется.");

//        Console.WriteLine($"Лодка плывёт по реке.");
//    }
//}
//public class Plane : Transport
//{
//    public override void Move()
//    {
//        Console.WriteLine($"{Model}: транспорт движется.");
//        Console.WriteLine($"Самолёт летит по небу.");
//    }
//}
//class Program
//    {
//    static void Main()
//{
//    Transport[] vehicles =
//    {
//            new Car { Model = "Audi" },
//            new Boat { Model = "Yamaha" },
//            new Plane { Model = "Boeing" }
//        };

//    foreach (var v in vehicles)
//    {
//        v.Move();
//        Console.WriteLine();
//    }
//}
//}
//#3
//public abstract class Shape
//{
//    public abstract double GetArea();
//}
//public class Circle : Shape
//{
//    public double Radius { get; set; }
//    public override double GetArea() => Math.PI * Radius * Radius;
//}

//public class Square : Shape
//{
//    public double Side { get; set; }
//    public override double GetArea() => Side * Side;
//}
//public class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Shape[] shapes =
//{
//    new Circle { Radius = 5 },
//    new Square { Side = 4 },
//    new Rectangle { Width = 3, Height = 6 }
//};

//        foreach (var s in shapes)
//        {
//            Console.WriteLine(Math.Round(s.GetArea(), 1));
//        }
//    }
//}
using System.Diagnostics.Metrics;
//#4
//public class Instrument
//{
//    public virtual void Play()
//    {
//        Console.WriteLine("Инструмент издаёт звук");
//    }
//}
//public class Guitar : Instrument
//{
//    public override void Play()
//    {
//        Console.WriteLine("Гитара играет аккорды");
//    }
//}

//public class Piano : Instrument
//{
//    public override void Play()
//    {
//        Console.WriteLine("Пианино играет мелодию");
//    }
//}

//public class Drum : Instrument
//{
//    public override void Play()
//    {
//        Console.WriteLine("Барабан бьёт ритм");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Instrument[] instruments =
//        {
//            new Guitar(),
//            new Piano(),
//            new Drum()
//        };

//        foreach (var i in instruments)
//        {
//            i.Play();
//        }
//    }
//}
//#5
//public abstract class Character
//{
//    public string Name { get; set; }
//    public abstract void Attack();
//}
//public class Warrior : Character
//{
//    public override void Attack()
//    {
//        Console.WriteLine("Воин атакует мечом!");
//    }
//}
//public class Mage : Character
//{
//    public override void Attack()
//    {
//        Console.WriteLine("Маг выпускает огненный шар!");
//    }
//}
//public class Archer : Character
//{
//    public override void Attack()
//    {
//        Console.WriteLine("Лучник стреляет из лука!");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Character[] team =
//        {
//            new Warrior { Name = "Алекс" },
//            new Mage { Name = "Лия" },
//            new Archer { Name = "Робин" }
//        };
//        foreach (var c in team)
//        {
//            Console.Write($"{c.Name}: ");
//            c.Attack();
//        }
//    }
//}