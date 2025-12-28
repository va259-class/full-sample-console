namespace Vektorel.Data.Concretes
{
    public sealed class City
    {
        public City() 
        {
            Id = Guid.NewGuid();
            Counties = new HashSet<County>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public HashSet<County> Counties { get; set; }
        public long Population 
        {
            //get
            //{
            //    var sum = 0U;
            //    foreach (var county in Counties)
            //    {
            //        sum += county.Population;
            //    }
            //    return sum;
            //} 

            get
            {
                // lambda expression
                return Counties.Sum(s => s.Population);
            }
        }
        //üstteki yazım ile aynı amaç
        public double Capacity => Counties.Sum(c => c.Capacity);

        public List<County> GetCounties()
        {
            return Counties.ToList();
        }
    }
}
