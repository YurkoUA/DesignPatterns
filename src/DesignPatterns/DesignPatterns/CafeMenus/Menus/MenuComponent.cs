using CafeMenus.Iterator;

namespace CafeMenus.Menus
{
    public abstract class MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsVegeterian { get; set; }

        public abstract IIterator<MenuComponent> CreateIterator();

        public virtual void Add(MenuComponent component)
        {
        }

        public virtual void Remove(MenuComponent component)
        {
        }

        public virtual MenuComponent GetChild(int index)
        {
            return null;
        }

        public virtual void Print()
        {
        }
    }
}
