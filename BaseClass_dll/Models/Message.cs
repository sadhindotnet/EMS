using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Message : BaseEntity
    {
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime SentAt { get; set; }
        [ValidateNever]

        public User Sender { get; set; }
        [ValidateNever]
        public User Receiver { get; set; }
    }

}
