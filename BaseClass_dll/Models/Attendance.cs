﻿namespace BaseClass_dll
{
    public class Attendance : BaseEntity
    {
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public Student Student { get; set; }
    }

}
