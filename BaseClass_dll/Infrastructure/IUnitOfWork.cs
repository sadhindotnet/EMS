using BaseClass_dll.Repositories;
using BaseClass_dll.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        public IUser? UserRepo { get; }
        public IAcademyClass? AcademyClassRepo { get; }
        public IAdmitCard? AdmitCardRepo { get; }

        public ISalary? SalaryRepo { get; }
        public ISchool? SchoolRepo { get; }
        public ISchoolClass? SchoolClassRepo { get; }
        public ISection? SectionRepo { get; }
        public IStaff? StaffRepo { get; }
        public IStaffAttendance? StaffAttendanceRepo { get; }
        public IStudent? StudentRepo { get; }
        public ISubject? SubjectRepo { get; }
        public ISubstituteAssignment? SubstituteAssignmentRepo { get; }
        public ITeacher? TeacherRepo { get; }
        public ITimetableEntry? TimetableEntryRepo { get; }
        public ITransaction? TransactionRepo { get; }
        public ISchoolClassSubject? SchoolClassSubjectRepo { get; }
        public IAttendance? AttendanceRepo { get; }
        public IBranch? BranchRepo { get; }
        public IClassSubject? ClassSubjectRepo { get; }
        public IEvent? EventRepo { get; }
        public IEventImage? EventImageRepo { get; }
        public IExam? ExamRepo { get; }
        public IExamRoutine? ExamRoutineRepo { get; }
        public IFee? FeeRepo { get; }
        public IFeedback? FeedbackRepo { get; }
        public IFeePayment? FeePaymentRepo { get; }
        public IFeeStructure? FeeStructureRepo { get; }
        public IHomework? HomeworkRepo { get; }
        public IHomeworkSubmission? HomeworkSubmissionRepo { get; }
        public IIDCard? IDCardRepo { get; }
        public ILeaveRequest? LeaveRequestRepo { get; }
        public IMessage? MessageRepo { get; }
        public INotice? NoticeRepo { get; }
        public INotification? NotificationRepo { get; }
        public IParent? ParentRepo { get; }

        public IResult? ResultRepo { get; }


        public Modelmessage Save();

    }
}
