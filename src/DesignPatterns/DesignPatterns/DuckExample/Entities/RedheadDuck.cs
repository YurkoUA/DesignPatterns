using System;
using DuckExample.Behaviour.Fly;
using DuckExample.Behaviour.Quack;

namespace DuckExample.Entities
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehaviour = new FlyWithWingsBehaviour();
            quackBehaviour = new QuackBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a redhead duck.");
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a redhead duck.");
        }
    }
}
