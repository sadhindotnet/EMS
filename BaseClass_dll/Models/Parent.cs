namespace BaseClass_dll
{
    public class Parent : BaseEntity
    {
        public int UserId { get; set; }
        public string NIDNumber { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public User User { get; set; }
        public ICollection<Student> Children { get; set; }
    }

}
