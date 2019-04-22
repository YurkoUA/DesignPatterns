using System;
using DuckExample.Behaviour.Fly;
using DuckExample.Behaviour.Quack;

namespace DuckExample.Entities
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFlyBehaviour();
            quackBehaviour = new MuteBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a wooden duck.");
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a wooden duck.");
        }
    }
}
