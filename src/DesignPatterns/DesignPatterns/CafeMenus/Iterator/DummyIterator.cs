namespace CafeMenus.Iterator
{
    public class DummyIterator<T> : IIterator<T>
    {
        public bool HasNext() => false;

        public T GetNext() => default(T);
    }
}
