namespace AbstractFactory.Domain
{
    public class PackingInorganic : Packing
    {
        public PackingInorganic() : base(TypeProduct.Inorganic) { }

        public override List<Packing> SearchPacking()
        {
            return new List<Packing>()
            {
                new PackingInorganic(){ Name = "Sacola Inorgânica 1" },
                new PackingInorganic(){ Name = "Sacola Inorgânica 2" },
                new PackingInorganic(){ Name = "Sacola Inorgânica 3" }

            };
        }
    }
}
