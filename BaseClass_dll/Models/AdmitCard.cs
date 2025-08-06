using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class AdmitCard : BaseEntity
    {
        
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string AdmitCardPath { get; set; }

        public DateTime IssuedDate { get; set; }
        [ValidateNever]
        public Student Student { get; set; }
        [ValidateNever]
        public Exam Exam { get; set; }
    }

}
