using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Homework : BaseEntity
    {
        public int AcademyClassId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        [ValidateNever]
        public Subject Subject { get; set; }
        [ValidateNever]
        public Teacher Teacher { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public ICollection<HomeworkSubmission> Submissions { get; set; }
    }

}
