using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class EventImage : BaseEntity
    {

        public int EventId { get; set; }

        public string ImagePath { get; set; } // stored path or URL
        [ValidateNever]
        public Event Event { get; set; }
    }

}
