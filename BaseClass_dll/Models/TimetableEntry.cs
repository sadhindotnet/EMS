namespace BaseClass_dll
{
    public class TimetableEntry : BaseEntity
    {

        public int AcademyClassId { get; set; }
        public int SectionId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public DayOfWeek DayOfWeek { get; set; } // Saturday, Sunday, etc.
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public AcademyClass AcademyClass { get; set; }
        public Section Section { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }

}
