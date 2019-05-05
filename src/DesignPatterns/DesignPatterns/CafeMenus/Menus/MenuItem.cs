using System;
using CafeMenus.Iterator;

namespace CafeMenus.Menus
{
    public class MenuItem : MenuComponent
    {
        public override IIterator<MenuComponent> CreateIterator()
        {
            return new DummyIterator<MenuComponent>();
        }

        public override void Print()
        {
            Console.WriteLine(string.Format("{0}{1}", Name, IsVegeterian ? " [V]" : string.Empty));
            Console.WriteLine(Price);

            if (!string.IsNullOrWhiteSpace(Description))
            {
                Console.WriteLine(Description);
            }
        }
    }
}
