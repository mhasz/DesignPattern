namespace AbstractFactory.Domain
{
    public class FoodOrganic : Food
    {
        public FoodOrganic() : base(TypeProduct.Organic) { }

        public override List<Food> SearchFood()
        {
            return new List<Food>()
            {
                new FoodOrganic { Name = "Tomate" },
                new FoodOrganic { Name = "Cebola" },
                new FoodOrganic { Name = "Alface" }
            };
        }
    }
}
