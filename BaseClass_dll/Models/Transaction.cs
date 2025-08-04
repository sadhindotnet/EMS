namespace BaseClass_dll
{
    public class Transaction : BaseEntity
    {
        public string Type { get; set; } // Income / Expense
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }

}
