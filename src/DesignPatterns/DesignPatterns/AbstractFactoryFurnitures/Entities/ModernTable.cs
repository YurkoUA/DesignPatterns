using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ModernTable : Table
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a table in modern style.");
        }
    }
}
