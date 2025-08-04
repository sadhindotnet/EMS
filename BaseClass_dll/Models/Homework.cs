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
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
        public AcademyClass AcademyClass { get; set; }
        public ICollection<HomeworkSubmission> Submissions { get; set; }
    }

}
