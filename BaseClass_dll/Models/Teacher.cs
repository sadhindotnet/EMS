namespace BaseClass_dll
{
    public class Teacher : BaseEntity
    {
        public int UserId { get; set; }
        public string NIDNumber { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public string PhotoPath { get; set; }
        public User User { get; set; }
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }

}
