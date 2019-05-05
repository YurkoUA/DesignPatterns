using System.Collections;
using System.Collections.Generic;

namespace CafeMenus.Iterator
{
    public class DummyEnumerator<T> : IEnumerator<T>
    {
        public T Current => default(T);

        object IEnumerator.Current => null;

        public bool MoveNext() => false;

        public void Reset()
        {
        }

        public void Dispose()
        {
        }
    }
}
