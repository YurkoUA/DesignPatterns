using System;
using DuckExample.Behaviour.Fly;
using DuckExample.Behaviour.Quack;

namespace DuckExample.Entities
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFlyBehaviour();
            quackBehaviour = new SpeakBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a rubber duck.");
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a rubber duck.");
        }
    }
}
