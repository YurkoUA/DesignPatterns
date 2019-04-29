using DuckExample.Interfaces;

namespace DuckExample.Entities
{
    public abstract class Duck
    {
        protected IQuackBehaviour quackBehaviour;
        protected IFlyBehaviour flyBehaviour;

        public abstract void Display();
        public abstract void Swim();

        public void PerformQuacking()
        {
            quackBehaviour.Quack();
        }

        public void PerformFlying()
        {
            flyBehaviour.Fly();
        }
    }
}
