namespace BaseClass_dll
{
    public class Event : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime EventDate { get; set; }

        public string Location { get; set; }

        public string TargetAudience { get; set; } // All, Teachers, Students, Parents

        public ICollection<EventImage> Images { get; set; }
    }

}
