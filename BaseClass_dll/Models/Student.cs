using static System.Collections.Specialized.BitVector32;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Student : BaseEntity
    {
        public int UserId { get; set; }
        public string RollNumber { get; set; }
        public string PhotoPath { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int AcademyClassId { get; set; }
        public int SectionId { get; set; }
        public string? PreviousSchool { get; set; }
        public DateTime AdmissionDate { get; set; }
        [ValidateNever]
        public User User { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public Section Section { get; set; }
        [ValidateNever]
        public ICollection<Attendance> Attendances { get; set; }
        [ValidateNever]
        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
        [ValidateNever]
        public ICollection<Result> Results { get; set; }
        [ValidateNever]
        public ICollection<FeePayment> FeePayments { get; set; }
    }

}
