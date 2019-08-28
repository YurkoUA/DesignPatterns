using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ArDecoTable : Table
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a table in ar-deco style.");
        }
    }
}
