using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseClass_dll
{
    public class Salary : BaseEntity
    {
        public int UserId { get; set; }
        [ValidateNever]
        public User User { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowance { get; set; }
        public decimal Bonus { get; set; }
        public decimal OvertimeAmount { get; set; }
        public int PermittedLeaveDays { get; set; }
        public int TotalLeaveDays { get; set; }
        public decimal TaxDeduction { get; set; } //Gross total theke minus hobe 
        public decimal LeaveDeduction { get; set; }
        public decimal NetSalary => (BasicSalary + Allowance + Bonus + OvertimeAmount ) - (LeaveDeduction + TaxDeduction)  ;
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

    }
}
