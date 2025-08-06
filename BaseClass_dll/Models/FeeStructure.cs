using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Security.Claims;

namespace BaseClass_dll
{
    public class FeeStructure : BaseEntity
    {
        public string FeeType { get; set; } // Tuition, Exam
        public decimal Amount { get; set; }
        public int AcademyClassId { get; set; }
        [ValidateNever]

        public AcademyClass AcademyClass { get; set; }
    }

}
