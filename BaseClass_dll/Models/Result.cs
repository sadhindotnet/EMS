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
        public Student Student { get; set; }
        public Subject Subject { get; set; }
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
