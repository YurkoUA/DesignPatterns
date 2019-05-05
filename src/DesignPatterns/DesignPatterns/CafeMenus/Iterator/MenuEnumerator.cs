using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CafeMenus.Menus;

namespace CafeMenus.Iterator
{
    public class MenuEnumerator : IEnumerator<MenuComponent>
    {
        private readonly Stack<IEnumerator<MenuComponent>> allEnumerators = new Stack<IEnumerator<MenuComponent>>();

        public MenuEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            allEnumerators.Push(enumerator);
        }

        public MenuComponent Current { get; private set; }
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (!allEnumerators.Any())
            {
                return false;
            }

            var enumerator = allEnumerators.Pop();

            if (enumerator.MoveNext())
            {
                Current = enumerator.Current;
                allEnumerators.Push(Current.CreateEnumerator());
                return true;
            }

            //allEnumerators.Pop();
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
