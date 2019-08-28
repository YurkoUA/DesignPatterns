using AbstractFactoryFurnitures.Entities;

namespace AbstractFactoryFurnitures.Factory
{
    public class ArDecoFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ArDecoChair();

        public Sofa CreateSofa() => new ArDecoSofa();

        public Table CreateTable() => new ArDecoTable();
    }
}
