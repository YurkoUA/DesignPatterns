using System;
using AbstractFactoryFurnitures.Factory;

namespace AbstractFactoryFurnitures
{
    class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory factory = null;

            factory = new ArDecoFurnitureFactory();
            CreateFurniture(factory);

            factory = new VictorianFurnitureFactory();
            CreateFurniture(factory);

            factory = new ModernFurnitureFactory();
            CreateFurniture(factory);

            Console.ReadKey();
        }

        static void CreateFurniture(IFurnitureFactory factory)
        {
            factory.CreateChair().ShowInfo();
            factory.CreateSofa().ShowInfo();
            factory.CreateTable().ShowInfo();

            Console.WriteLine();
        }
    }
}
