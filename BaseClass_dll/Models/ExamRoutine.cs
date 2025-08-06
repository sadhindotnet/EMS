using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public Exam Exam { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public Section Section { get; set; }
    }

}
