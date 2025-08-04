namespace BaseClass_dll
{
    public class Message : BaseEntity
    {
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentAt { get; set; }

        public User Sender { get; set; }
        public User Receiver { get; set; }
    }

}
