using System;

namespace Adapter.Entities
{
    public class MallardDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("I'm flying.");
        }

        public override void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
