using System;
using DuckExample.Interfaces;

namespace DuckExample.Behaviour.Fly
{
    public class FlyWithWingsBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly with wings.");
        }
    }
}
