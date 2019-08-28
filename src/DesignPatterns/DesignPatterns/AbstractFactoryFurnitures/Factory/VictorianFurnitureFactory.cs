using AbstractFactoryFurnitures.Entities;

namespace AbstractFactoryFurnitures.Factory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new VictorianChair();

        public Sofa CreateSofa() => new VictorianSofa();

        public Table CreateTable() => new VictorianTable();
    }
}
