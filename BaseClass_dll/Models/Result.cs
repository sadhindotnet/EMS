using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Result : BaseEntity
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int ExamId { get; set; }
        public double TotalMarks { get; set; }
        public double PassMarks { get; set; }
        public double MarksObtained { get; set; }
        public double GPA { get; set; }
        [ValidateNever]
        public Student Student { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
        [ValidateNever]
        public Exam Exam { get; set; }

        public string Status
        {
            get
            {
                return MarksObtained >= PassMarks ? "Pass" : "Fail";
            }
        }
    }
}
