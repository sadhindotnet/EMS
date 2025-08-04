using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaseClass_dll.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<BaseEntity> BaseEntities { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<AcademyClass> AcademyClasses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClassSubject> SchoolClassSubjects { get; set; }
        public DbSet<ClassSubject> ClassSubjects { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<StaffAttendance> StaffAttendances { get; set; }

        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<TimetableEntry> TimetableEntries { get; set; }
        public DbSet<SubstituteAssignment> SubstituteAssignments { get; set; }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamRoutine> ExamRoutines { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<AdmitCard> AdmitCards { get; set; }
        public DbSet<IDCard> IdCards { get; set; }

        public DbSet<Fee> Fees { get; set; }
        public DbSet<FeeStructure> FeeStructures { get; set; }
        public DbSet<FeePayment> FeePayments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventImage> EventImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
