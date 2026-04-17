//#1-4
//public class Animal
//{
//    public string Name { get; set; }
//    public Animal(string name)
//    {
//        Name = name;
//        Console.WriteLine($"Создано животное: {Name}");
//    }
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издаёт звук");
//    }
//    public void Eat()
//    {
//        Console.WriteLine($"{Name} ест");
//    }
//    public virtual void Move()
//    {
//        Console.WriteLine("Животное двигается");
//    }
//}
//public class Dog : Animal
//{
//    public Dog(string name) : base(name) { }
//    public void Bark()
//    {
//        Console.WriteLine($"{Name} лает");
//    }
//    public virtual void Speak()
//    {
//        Console.WriteLine($"{Name} лает: Гав-гав");
//    }
//    public override void Move()
//    {
//        base.Move();
//        Console.WriteLine("Собака бежит по дороге.");
//    }
//}
//public class Cat : Animal
//{
//    public Cat(string name) : base(name)
//    {
//        Console.WriteLine($"Создана кошка по имени {Name}");
//    }
//    public void Meow()
//    {
//        Console.WriteLine($"{Name} мяукает");
//    }
//    public virtual void Speak()
//    {
//        Console.WriteLine($"{Name} мяукает: Мяу");
//    }
//}
//class Program
//{
//    static void Main()
//    {
        //#4
        //var cat = new Cat("Мурка");
        //cat.Eat();
        //cat.Meow();
        //#1+3
        //var dog = new Dog();
        //dog.Name = "Шарик";
        //dog.Move();
        //#2
        //var dog = new Dog { Name = "Шарик" };
        //var cat = new Cat { Name = "Мурка" };

        //dog.Speak();
//        //cat.Speak();

//    }
//}
//#5
//class Program
//{
//    static void Main()
//    {
//        Transport transport = new Transport();
//        Car car = new Car();
//        ElectricCar tesla = new ElectricCar();
//        transport.Drive();
//        car.Drive();
//        tesla.Drive();
//    }
//}
//public class Transport
//{
//    public virtual void Drive()
//    {
//        Console.WriteLine("Транспорт движется");
//    }
//}
//public class Car : Transport
//{
//    public override void Drive()
//    {
//        Console.WriteLine("Машина едет по дороге");
//    }
//}
//public class ElectricCar : Car
//{
//    public override void Drive()
//    {
//        Console.WriteLine("Электромобиль тихо едет на батарее");
//    }
//}
