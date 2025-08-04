namespace BaseClass_dll
{
    public class StaffAttendance : BaseEntity
    {
        public int StaffId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public Staff Staff { get; set; }
    }
}
