using System;
using System.Collections.Generic;
using System.Text;

public abstract class Worker
{
    public string Name { get; set; }
    public abstract void Work();
    public void ShowInfo()
    {
        Console.WriteLine($"Работник : {Name}");
    }
}
class Manager : Worker
{
    public override void Work()
    {
        Console.WriteLine($"{Name} планирует задачи");
    }
}
class Developer : Worker
{
    public override void Work()
    {
        Console.WriteLine($"{Name} Пишет код");
    }
}