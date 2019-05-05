using System;
using System.Collections.Generic;
using CafeMenus.Iterator;

namespace CafeMenus.Menus
{
    public class Menu : MenuComponent
    {
        private IList<MenuComponent> menuComponents = new List<MenuComponent>();

        public override IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new MenuEnumerator(menuComponents.GetEnumerator());
        }

        public override void Add(MenuComponent component)
        {
            menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int index)
        {
            return menuComponents[index];
        }

        public override void Print()
        {
            Console.WriteLine($"Menu {Name} - {Description}");

            var enumerator = CreateEnumerator();

            while (enumerator.MoveNext())
            {
                enumerator.Current.Print();
            }
        }
    }
}
