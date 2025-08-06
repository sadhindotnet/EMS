using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class IDCard : BaseEntity
    {
        public int UserId { get; set; }
        public string IDCardPath { get; set; }
        public int PrintCount { get; set; }

        public DateTime IssuedDate { get; set; }
        [ValidateNever]
        public User User { get; set; }
    }
    }
