using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public User User { get; set; }
        [ValidateNever]
        public ICollection<Student> Children { get; set; }
    }

}
