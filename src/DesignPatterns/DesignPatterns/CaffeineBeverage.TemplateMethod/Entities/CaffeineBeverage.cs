using System;

namespace CaffeineBeverageTemplateMethod.Entities
{
    public abstract class CaffeineBeverage
    {
        public void Cook()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddSugar();

            if (RequiresCondiments())
            {
                AddCondiments();
            }

            Console.WriteLine("Your beverage is done!\n");
        }

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water.");
        }

        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }

        protected virtual void AddSugar()
        {
            Console.WriteLine("Adding sugar.");
        }

        protected virtual bool RequiresCondiments() => false;

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }
}
