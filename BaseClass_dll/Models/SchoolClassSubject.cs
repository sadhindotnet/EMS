namespace BaseClass_dll
{
    public class SchoolClassSubject : BaseEntity
    {
        public int SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }

}
