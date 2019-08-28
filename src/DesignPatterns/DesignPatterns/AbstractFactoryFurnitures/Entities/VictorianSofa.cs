using System;

namespace AbstractFactoryFurnitures.Entities
{
    public class VictorianSofa : Sofa
    {
        public override void ShowInfo()
        {
            Console.WriteLine("It's a sofa in Victorian style.");
        }
    }
}
