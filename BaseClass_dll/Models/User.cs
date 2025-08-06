using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin, Teacher, Student, Parent, Accountant
        //public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        [ValidateNever]
        public Student? Student { get; set; }
        [ValidateNever]
        public Parent? Parent { get; set; }
        [ValidateNever]
        public Teacher? Teacher { get; set; }
    }

}
