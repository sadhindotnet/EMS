namespace BaseClass_dll
{
    public class SchoolClass : BaseEntity
    {
        public int SchoolId { get; set; }
        public School School { get; set; }

        public int AcademyClassId { get; set; }
        public AcademyClass AcademyClass { get; set; }

        public string? CustomName { get; set; } // onek school class same academy class er jonno custom name dite parbe

        public ICollection<SchoolClassSubject> SchoolClassSubjects { get; set; } = new List<SchoolClassSubject>();
    }

}
