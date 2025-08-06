using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class FeePayment : BaseEntity
    {
        public int StudentId { get; set; }
        public int FeeStructureId { get; set; }

        public decimal PaidAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        [ValidateNever]
        public Student Student { get; set; }
        [ValidateNever]
        public FeeStructure FeeStructure { get; set; }
    }

}
