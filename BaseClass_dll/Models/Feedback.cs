namespace BaseClass_dll
{
    public class Feedback : BaseEntity
    {
        public int UserId { get; set; }
        public string Message { get; set; }
        public string Category { get; set; } // Complaint, Suggestion, Inquiry
        public DateTime SubmittedAt { get; set; }

        public User User { get; set; }
    }

}
