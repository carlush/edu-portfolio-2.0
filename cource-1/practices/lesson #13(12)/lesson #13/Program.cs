using System.Xml.Linq;
//#1

//public class Person
//{
//    private string name;
//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//            {
//                Console.WriteLine("Ошибка: Имя не может быть пустым.");
//            }
//            else
//            {
//                name = value;
//            }
//        }
//    }
//    private int age;
//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value >= 0)
//                age = value;
//            else
//                Console.WriteLine("Возраст не может быть отрицательным!");
//        }
//    }
//}
//public class Program
//{
//    static void Main()
//    {
//        var p = new Person();
//        p.Name = "Алиса";
//        p.Age = 25;
//        p.Age = -5;
//        p.Name = "";
//        Console.WriteLine($"Итоговые данные: {p.Name}, {p.Age}");
//    }
//}

//#2

//public class BankAccount
//{
//    private decimal balance;

//    public void Deposit(decimal amount)
//    {
//        if (balance >= 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Счёт пополнен на {amount}. Текущий баланс: {balance}");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: Сумма пополнения должна быть больше нуля.");
//        }
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount <= 0)
//        {
//            Console.WriteLine("Ошибка: Сумма снятия должна быть больше нуля.");
//        }
//        else if (amount > balance)
//        {
//            Console.WriteLine($"Ошибка: Недостаточно средств! Попытка снять: {amount}, доступно: {balance}");
//        }
//        else
//        {
//            balance -= amount;
//            Console.WriteLine($"Вы сняли {amount}. Остаток на счёте: {balance}");
//        }
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine($"Баланс: {balance}");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        var myAccount = new BankAccount();

//        myAccount.Deposit(1000);
//        myAccount.Withdraw(400);
//        myAccount.Withdraw(1000);
//        myAccount.ShowBalance();
//    }
//}

//#3

//public class Thermometer
//{
//    private double temperatureCelsius;
//    public double TemperatureCelsius
//    {
//        get { return temperatureCelsius; }
//        set
//        {
//            if (value < -273)
//            {
//                Console.WriteLine("Ошибка: Температура не может быть ниже -273°C.");
//            }
//            else
//            {
//                temperatureCelsius = value;
//            }
//        }
//    }

//    public double TemperatureFahrenheit
//    {
//        get
//        {
//            return (temperatureCelsius * 9 / 5) + 32;
//        }
//    }
//}
//    class Program
//{
//    static void Main()
//    {
//        var term = new Thermometer();
//        term.TemperatureCelsius = 25;
//        Console.WriteLine($"Цельсии: {term.TemperatureCelsius}°C");
//        Console.WriteLine($"Фаренгейты: {term.TemperatureFahrenheit}°F");

//        Console.WriteLine();
//        term.TemperatureCelsius = -300;
//    }
//}

//#4

//public class Animal
//{
//    protected int energy = 100;

//    public void Eat()
//    {
//        energy += 10;
//        Console.WriteLine($"Собака поела. Энергия увеличилась: {energy}");
//    }
//    public void ShowStatus()
//    {
//        Console.WriteLine($"Текущий уровень энергии: {energy}");
//    }
//}

//public class Dog : Animal
//{
//    public void Run()
//    {
//        if (energy >= 20)
//        {
//            energy -= 20;
//            Console.WriteLine($"Собака побегала. Энергия уменьшилась: {energy}");
//        }
//        else
//        {
//            Console.WriteLine("Собака слишком устала, чтобы бежать!");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var dog = new Dog();
//        dog.ShowStatus();
//        dog.Run();
//        dog.Run();
//        dog.Eat();
//        dog.Run();
//        dog.Eat();
//    }
//}