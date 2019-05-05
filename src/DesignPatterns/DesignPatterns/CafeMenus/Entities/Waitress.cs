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
            var enumerator = menuComponent.CreateEnumerator();

            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;

                if (item.IsVegeterian == true)
                {
                    item.Print();
                }
            }
        }
    }
}
