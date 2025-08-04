namespace BaseClass_dll
{
    public class Notification : BaseEntity
    {
        public int UserId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
    }

}
