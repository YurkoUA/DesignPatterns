using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Quack
{
    public class SpeakBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I speak like a human.");
        }
    }
}
