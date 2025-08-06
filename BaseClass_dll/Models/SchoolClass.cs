using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class SchoolClass : BaseEntity
    {
        public int SchoolId { get; set; }
        [ValidateNever]
        public School School { get; set; }

        public int AcademyClassId { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }

        public string? CustomName { get; set; } // onek school class same academy class er jonno custom name dite parbe
        [ValidateNever]

        public ICollection<SchoolClassSubject> SchoolClassSubjects { get; set; } = new List<SchoolClassSubject>();
    }

}
