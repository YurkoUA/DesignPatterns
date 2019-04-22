using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Quack
{
    public class SqueakBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I squeak.");
        }
    }
}
