using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Quack
{
    public class MuteBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("---");
        }
    }
}
