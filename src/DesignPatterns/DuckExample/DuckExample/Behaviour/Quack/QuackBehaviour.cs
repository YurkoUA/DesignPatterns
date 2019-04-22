using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Quack
{
    public class QuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I quack like a simple duck.");
        }
    }
}
