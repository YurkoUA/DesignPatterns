using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ArDecoChair : Chair
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a chair in ar-deco style.");
        }
    }
}
