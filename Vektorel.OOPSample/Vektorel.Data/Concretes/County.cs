namespace Vektorel.Data.Concretes
{
    public class County
    {
        public County()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Capacity { get; set; }
        public uint Population { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var compared = obj as County;
            if (compared is null)
            {
                return false;
            }
            return Name.Equals(compared.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
