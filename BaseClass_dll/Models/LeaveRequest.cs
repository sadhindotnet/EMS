using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseClass_dll
{
    public class LeaveRequest : BaseEntity
    {

        public int UserId { get; set; }               // Leave নিচ্ছে যিনি
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Reason { get; set; }
        public string LeaveType { get; set; }         // Sick, Casual, Unpaid etc.
        public string Status { get; set; }            // Pending, Approved, Rejected

        public int? ApprovedBy { get; set; }          // যিনি Approve করেছেন (nullable)
        [ForeignKey("ApprovedBy")]
        public User ApprovedByUser { get; set; }

        public bool IsSalaryDeducted { get; set; }    // Salary থেকে কাটবে কি না

        // Leave এর মোট দিন, DB তে stored না, calculated property
        [NotMapped]
        public int LeaveDays => (EndDate - StartDate).Days + 1;
    }
}
