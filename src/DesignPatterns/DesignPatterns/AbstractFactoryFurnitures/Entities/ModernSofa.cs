using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ModernSofa : Sofa
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a sofa in modern style.");
        }
    }
}
