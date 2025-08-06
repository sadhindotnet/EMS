using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Security.Claims;

namespace BaseClass_dll
{
    public class ClassSubject : BaseEntity
    {
        public int AcademyClassId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
        [ValidateNever]
        public Teacher Teacher { get; set; }
    }

}
