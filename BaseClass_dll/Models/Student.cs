using static System.Collections.Specialized.BitVector32;
using System.Security.Claims;

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
        public User User { get; set; }
        public AcademyClass AcademyClass { get; set; }
        public Section Section { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public ICollection<Result> Results { get; set; }
        public ICollection<FeePayment> FeePayments { get; set; }
    }

}
