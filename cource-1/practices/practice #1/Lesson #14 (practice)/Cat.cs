using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__14__practice_
{
    public class Cat : Animal
    {
        public Cat() : base("Кошка") { }
        public Cat(string name) : base(name) { }

        public void Meow()
        {
            Console.WriteLine($"{Name} пытается мяукать...");
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Мяу!");
        }
    }
}
