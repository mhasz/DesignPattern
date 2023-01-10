namespace AbstractFactory.Domain
{
    public abstract class Packing
    {
        public Packing(TypeProduct typeProduct)
        {
            Type = typeProduct;
        }

        public string Name { get; set; }
        public TypeProduct Type { get; set; }

        public abstract List<Packing> SearchPacking();
    }
}
