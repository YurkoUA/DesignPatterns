using System.Collections.Generic;
using System.Linq;
using CafeMenus.Menus;

namespace CafeMenus.Iterator
{
    public class CompositeIterator : IIterator<MenuComponent>
    {
        private readonly Stack<IIterator<MenuComponent>> iterators = new Stack<IIterator<MenuComponent>>();

        public CompositeIterator(IIterator<MenuComponent> iterator)
        {
            iterators.Push(iterator);
        }

        public bool HasNext()
        {
            if (!iterators.Any())
            {
                return false;
            }

            var iter = iterators.Peek();

            if (!iter.HasNext())
            {
                iterators.Pop();
                return HasNext();
            }

            return true;
        }

        public MenuComponent GetNext()
        {
            if (!HasNext())
            {
                return null;
            }

            var iter = iterators.Peek();
            var component = iter.GetNext();

            iterators.Push(component.CreateIterator());
            return component;
        }
    }
}
