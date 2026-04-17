using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__14__practice_
{
    public class Dog : Animal
    {
        public Dog() : base("Собака") { }
        public Dog(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{Name} пытается лаять...");
            MakeSound(); // пока общий звук
        }
        public override void MakeSound()
        {
            base.MakeSound();                 // (опционально) расширяем поведение
            Console.WriteLine($"{Name}: Гав-гав!");
        }
    }
}
