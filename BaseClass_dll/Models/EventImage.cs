namespace BaseClass_dll
{
    public class EventImage : BaseEntity
    {

        public int EventId { get; set; }

        public string ImagePath { get; set; } // stored path or URL

        public Event Event { get; set; }
    }

}
