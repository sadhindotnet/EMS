namespace BaseClass_dll
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Branch>? Branches { get; set; }
        public ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();

    }
}
