using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Staff : BaseEntity
    {
        public int UserId { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string PhotoPath { get; set; }
        [ValidateNever]
        public User User { get; set; }
        [ValidateNever]
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
