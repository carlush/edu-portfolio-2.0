using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__14__practice_
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal() : this("Неизвестно") { }
        public Animal(string name) { Name = name; }

        public void Eat()
        {
            ChangeEnergy(+10);
            Console.WriteLine($"{Name} ест. Энергия: {_energy}");
        }

        public void Rest()
        {
            ChangeEnergy(+5);
            Console.WriteLine($"{Name} отдыхает. Энергия: {_energy}");
        }
        private int _energy = 100;
        private void ChangeEnergy(int delta)
        {
            _energy += delta;
            if (_energy < 0) _energy = 0;
            if (_energy > 150) _energy = 150;
        }
        public virtual void MakeSound()
        {
            ChangeEnergy(-5);
            Console.WriteLine($"{Name} издаёт общий звук. Энергия: {_energy}");
        }
    }
}
