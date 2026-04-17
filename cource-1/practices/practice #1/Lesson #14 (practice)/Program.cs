using Lesson__14__practice_;

public class Program
{
    static void Main()
    {
        var a1 = new Animal();
        var a2 = new Animal("Мурка");
        var a3 = new Animal { Name = "Шарик" };

        a1.Eat(); a2.Eat(); a3.Eat();
        var a = new Animal("Чип");
        a.MakeSound();
        a.Eat();
        a.Rest();
        var d = new Dog("Шарик");
        var c = new Cat("Мурка");
        var e = new Elephant("Дамбо");
        d.Bark(); c.Meow(); e.Trumpet();
        Animal[] zoo =
{
    new Dog("Шарик"),
    new Cat("Мурка"),
    new Elephant("Дамбо"),
    new Animal("Неопознанный")
};

        foreach (var a4 in zoo)
        {
            a4.MakeSound(); // у каждого -- свой результат
        }
        var zooPark = new Zoo(5);
        zooPark.Add(new Dog("Рекс"));
        zooPark.Add(new Cat("Снежок"));
        zooPark.Add(new Elephant("Балу"));

        Console.WriteLine("=== Звуки ===");
        zooPark.MakeAllSounds();

        Console.WriteLine("=== Кормим ===");
        zooPark.FeedAll();
    }
}
