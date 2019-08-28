using AbstractFactoryFurnitures.Entities;

namespace AbstractFactoryFurnitures.Factory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ModernChair();

        public Sofa CreateSofa() => new ModernSofa();

        public Table CreateTable() => new ModernTable();
    }
}
