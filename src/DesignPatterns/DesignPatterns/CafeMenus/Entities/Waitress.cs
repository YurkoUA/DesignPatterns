using CafeMenus.Menus;

namespace CafeMenus.Entities
{
    public class Waitress
    {
        private readonly MenuComponent menuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            this.menuComponent = menuComponent;
        }

        public void Print()
        {
            menuComponent.Print();
        }

        public void PrintVegeterianMenu()
        {
            var iterator = menuComponent.CreateIterator();

            while (iterator.HasNext())
            {
                var item = iterator.GetNext();

                if (item.IsVegeterian)
                {
                    item.Print();
                }
            }
        }
    }
}
