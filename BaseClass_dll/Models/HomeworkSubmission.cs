namespace BaseClass_dll
{
    public class HomeworkSubmission : BaseEntity
    {
        public int HomeworkId { get; set; }
        public int StudentId { get; set; }

        public DateTime SubmittedDate { get; set; }
        public string FilePath { get; set; }
        public List<string> IFromFilePaths { get; set; }
        public string Feedback { get; set; }

        public Homework Homework { get; set; }
        public Student Student { get; set; }
    }

}
