namespace AbstractFactory.Domain
{
    public class FoodInorganic : Food
    {
        public FoodInorganic() : base(TypeProduct.Inorganic) { }

        public override List<Food> SearchFood()
        {
            return new List<Food>()
            {
                new FoodInorganic() { Name = "Batata Frita" },
                new FoodInorganic() { Name = "Biscoito" },
                new FoodInorganic() { Name = "Salgadinho" }
            };
        }
    }
}
