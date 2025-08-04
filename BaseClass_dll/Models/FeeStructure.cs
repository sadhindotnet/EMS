using System.Security.Claims;

namespace BaseClass_dll
{
    public class FeeStructure : BaseEntity
    {
        public string FeeType { get; set; } // Tuition, Exam
        public decimal Amount { get; set; }
        public int AcademyClassId { get; set; }

        public AcademyClass AcademyClass { get; set; }
    }

}
