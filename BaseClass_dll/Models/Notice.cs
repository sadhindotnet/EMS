namespace BaseClass_dll
{
    public class Notice : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public DateTime PublishDate { get; set; }
        public string TargetAudience { get; set; } // All, Students, Teachers, Parents
    }

}
