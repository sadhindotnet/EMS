namespace BaseClass_dll
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SchoolClassSubject> SchoolClassSubjects { get; set; } = new List<SchoolClassSubject>();

    }

}
