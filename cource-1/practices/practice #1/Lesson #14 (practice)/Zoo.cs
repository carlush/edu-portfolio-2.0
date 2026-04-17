using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__14__practice_
{
    public class Zoo
    {
        private Animal[] _animals;
        private int _count = 0;

        public Zoo(int capacity)
        {
            if (capacity <= 0) capacity = 1;
            _animals = new Animal[capacity];
        }

        public bool Add(Animal animal)
        {
            if (_count >= _animals.Length) return false; // нет места
            _animals[_count++] = animal;
            return true;
        }

        public void MakeAllSounds()
        {
            for (int i = 0; i < _count; i++)
                _animals[i].MakeSound();
        }

        public void FeedAll()
        {
            for (int i = 0; i < _count; i++)
                _animals[i].Eat();
        }
    }
}