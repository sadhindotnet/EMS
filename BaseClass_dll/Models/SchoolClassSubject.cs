using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class SchoolClassSubject : BaseEntity
    {
        public int SchoolClassId { get; set; }
        [ValidateNever]
        public SchoolClass SchoolClass { get; set; }
        [ValidateNever]
        public int SubjectId { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
    }

}
