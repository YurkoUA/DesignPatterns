using System;
using System.Collections.Generic;
using CafeMenus.Iterator;

namespace CafeMenus.Menus
{
    public class Menu : MenuComponent
    {
        private IList<MenuComponent> menuComponents = new List<MenuComponent>();

        public override IIterator<MenuComponent> CreateIterator()
        {
            return new CompositeIterator(new ListIterator<MenuComponent>(menuComponents));
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

            foreach (var m in menuComponents)
            {
                m.Print();
            }
        }
    }
}
