using AbstractFactoryFurnitures.Entities;

namespace AbstractFactoryFurnitures.Factory
{
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        Table CreateTable();
    }
}
