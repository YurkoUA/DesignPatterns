using System.Collections.Generic;
using System.Linq;

namespace CafeMenus.Iterator
{
    public class ListIterator<T> : IIterator<T>
    {
        private readonly IList<T> list;
        private int position = 0;

        public ListIterator(IList<T> list)
        {
            this.list = list;
        }

        public bool HasNext()
        {
            return position < list.Count();
        }

        public T GetNext()
        {
            var item = list[position];
            position++;
            return item;
        }
    }
}
