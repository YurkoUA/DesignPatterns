using System;
using DuckExample.Behaviour.Fly;
using DuckExample.Behaviour.Quack;

namespace DuckExample.Entities
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehaviour = new NoFlyBehaviour();
            quackBehaviour = new SqueakBehaviour();
        }

        public override void Display()
        {
            Console.WriteLine("I look like a decoy duck.");
        }

        public override void Swim()
        {
            Console.WriteLine("I swim like a decoy duck.");
        }
    }
}
