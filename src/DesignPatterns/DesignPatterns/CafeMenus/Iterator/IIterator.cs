namespace CafeMenus.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T GetNext();
    }
}
