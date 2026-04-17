using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson__15
{
    public interface IPlayable
    {
        void Play();
    }
    public class Guitar : IPlayable
    {
        public void Play() => Console.WriteLine("Гитара играет аккорды");
    }
    public class Piano : IPlayable
    {
        public void Play() => Console.WriteLine("Пианино играет мелодию");
    }
    public class Drum : IPlayable
    {
        public void Play() => Console.WriteLine("Барабан отбивает ритм");
    }
}
