using AbstractFactory.Domain;

namespace AbstractFactory.AbstractFactories
{
    public class ProductOrganicFactory : ProductFactory
    {
        public override Food CreateFood()
        {
            return new FoodOrganic();
        }

        public override Packing CreatePacking()
        {
            return new PackingOrganic();
        }
    }
}
