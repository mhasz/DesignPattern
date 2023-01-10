namespace AbstractFactory.Domain
{
    public abstract class Food
    {
        public Food(TypeProduct type)
        {
            Type = type;
        }

        public string Name { get; set; }
        public TypeProduct Type { get; set; }

        public abstract List<Food> SearchFood();
    }
}
