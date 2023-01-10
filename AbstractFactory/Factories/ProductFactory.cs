using AbstractFactory.Domain;

namespace AbstractFactory.AbstractFactories
{
    public abstract class ProductFactory
    {
        public abstract Food CreateFood();
        public abstract Packing CreatePacking();
    }
}
