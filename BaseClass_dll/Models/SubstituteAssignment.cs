namespace BaseClass_dll
{
    public class SubstituteAssignment : BaseEntity
    {
        public int TimetableEntryId { get; set; }  // Which class/subject
        public int AbsentTeacherId { get; set; }
        public int SubstituteTeacherId { get; set; }
        public DateTime Date { get; set; }

        public Teacher AbsentTeacher { get; set; }
        public Teacher SubstituteTeacher { get; set; }
        public TimetableEntry TimetableEntry { get; set; }
    }

}
