using System;
using System.Collections.Generic;
using CafeMenus.Iterator;

namespace CafeMenus.Menus
{
    public class MenuItem : MenuComponent
    {
        public override IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new DummyEnumerator<MenuComponent>();
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
