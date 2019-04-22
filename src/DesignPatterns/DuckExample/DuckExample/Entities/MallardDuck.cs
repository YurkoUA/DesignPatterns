using System;
using DuckExample.Behaviour.Fly;
using DuckExample.Behaviour.Quack;

namespace DuckExample.Entities
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWingsBehaviour();
            quackBehaviour = new QuackBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a mallard duck.");
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a mallard duck.");
        }
    }
}
