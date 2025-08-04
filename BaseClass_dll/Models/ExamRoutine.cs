namespace BaseClass_dll
{
    public class ExamRoutine : BaseEntity
    {
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public int AcademyClassId { get; set; }
        public int SectionId { get; set; }
        public DateTime ExamDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Exam Exam { get; set; }
        public Subject Subject { get; set; }
        public AcademyClass AcademyClass { get; set; }
        public Section Section { get; set; }
    }

}
