namespace BaseClass_dll
{
    public class AdmitCard : BaseEntity
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string AdmitCardPath { get; set; }

        public DateTime IssuedDate { get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }

}
