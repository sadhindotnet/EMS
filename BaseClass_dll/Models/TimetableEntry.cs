using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public Section Section { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
        [ValidateNever]
        public Teacher Teacher { get; set; }
    }

}
