using AbstractFactory.Domain;

namespace AbstractFactory.AbstractFactories
{
    public class ProductInorganicFactory : ProductFactory
    {
        public override Food CreateFood()
        {
            return new FoodInorganic();
        }

        public override Packing CreatePacking()
        {
            return new PackingInorganic();
        }
    }
}
