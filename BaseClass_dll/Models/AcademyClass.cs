using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using static System.Collections.Specialized.BitVector32;

namespace BaseClass_dll
{
    public class AcademyClass : BaseEntity
    {
        public string Name { get; set; }
        [ValidateNever]
        public ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();
        [ValidateNever]
        public ICollection<Section> Sections { get; set; }
        [ValidateNever]
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
