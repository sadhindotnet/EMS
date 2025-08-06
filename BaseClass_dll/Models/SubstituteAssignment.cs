using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class SubstituteAssignment : BaseEntity
    {
        public int TimetableEntryId { get; set; }  // Which class/subject
        public int AbsentTeacherId { get; set; }
        public int SubstituteTeacherId { get; set; }
        public DateTime Date { get; set; }
        [ValidateNever]

        public Teacher AbsentTeacher { get; set; }
        [ValidateNever]
        public Teacher SubstituteTeacher { get; set; }
        [ValidateNever]
        public TimetableEntry TimetableEntry { get; set; }
    }

}
