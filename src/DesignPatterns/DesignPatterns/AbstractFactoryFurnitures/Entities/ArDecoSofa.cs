using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class ArDecoSofa : Sofa
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a sofa in ar-deco style.");
        }
    }
}
