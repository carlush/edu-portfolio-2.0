using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__14__practice_
{
    public class Elephant : Animal
    {
        public Elephant() : base("Слон") { }
        public Elephant(string name) : base(name) { }

        public void Trumpet()
        {
            Console.WriteLine($"{Name} трубит хоботом...");
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Трууу!");
        }
    }
}
