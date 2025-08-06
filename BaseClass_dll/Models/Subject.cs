using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        [ValidateNever]
        public ICollection<SchoolClassSubject> SchoolClassSubjects { get; set; } = new List<SchoolClassSubject>();

    }

}
