using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class VictorianChair : Chair
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a chain in Victorian style.");
        }
    }
}
