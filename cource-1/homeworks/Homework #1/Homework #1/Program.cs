using System;
using static System.Net.Mime.MediaTypeNames;
test
//class Program
//{
//    static void Main()
//    {
//        var car = new Car { Model = "Audi" };
//        car.Accelerate(100);
//        car.ShowInfo();
//        car.Move();

//        var bike = new Bicycle { Model = "Cube" };
//        bike.Pedal();
//        bike.ShowInfo();
//        bike.Move();

//        Console.WriteLine(new string('-', 20));
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
//// #1
//public class Transport
//{
//    public string Model { get; set; }
//    protected int Speed { get; set; } = 0;

//    public void ShowInfo()
//    {
//        Console.WriteLine($"Модель: {Model}, скорость: {Speed} км/ч");
//    }

//    public virtual void Move()
//    {
//        Console.WriteLine("Транспорт движется");
//    }
//}
//public class Car : Transport
//{
//    public void Accelerate(int value)
//    {
//        if (Speed + value > 200)
//        {
//            Console.WriteLine("Слишком большая скорость!");
//        }
//        else
//        {
//            Speed += value;
//        }
//    }

//    public override void Move()
//    {
//        Console.WriteLine("Машина едет по дороге");
//    }
//}
//public class Bicycle : Transport
//{
//    public void Pedal()
//    {
//        Speed += 5;
//    }

//    public override void Move()
//    {
//        Console.WriteLine("Велосипед крутит педали");
//    }
//}
////#2
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
