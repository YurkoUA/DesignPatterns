using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class VictorianTable : Table
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a table in Victorian style.");
        }
    }
}
