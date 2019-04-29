using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Fly
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
