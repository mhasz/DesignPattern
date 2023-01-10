namespace AbstractFactory.Domain
{
    public class PackingOrganic : Packing
    {
        public PackingOrganic() : base(TypeProduct.Organic) { }

        public override List<Packing> SearchPacking()
        {
            return new List<Packing>()
            {
                new PackingOrganic(){ Name = "Sacola orgânica 1" },
                new PackingOrganic(){ Name = "Sacola orgânica 2" },
                new PackingOrganic(){ Name = "Sacola orgânica 3" }

            };
        }
    }
}
