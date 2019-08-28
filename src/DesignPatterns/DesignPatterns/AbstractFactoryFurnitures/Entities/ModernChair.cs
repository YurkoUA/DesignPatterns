using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ModernChair : Chair
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a chair in modern style.");
        }
    }
}
