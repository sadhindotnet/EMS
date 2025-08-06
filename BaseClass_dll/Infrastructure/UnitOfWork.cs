using BaseClass_dll.Models;
using BaseClass_dll.Repositories;
using BaseClass_dll.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Infrastructure
{//hasib
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext db)
        {
            context = db;
        }

        //public IUser user;
        //public IUser UserRepo
        //{
        //    get
        //    {
        //        if (user == null)
        //        {
        //            user = new UserRepo(context);
        //        }
        //        return user;
        //    }

        //}
        private IUser user;
        public IUser UserRepo => user ??= new UserRepo(context);

        private IAcademyClass academyClass;
        public IAcademyClass AcademyClassRepo => academyClass ??= new AcademyClassRepo(context);



        private IAdmitCard admitCard;
        public IAdmitCard AdmitCardRepo => admitCard ??= new AdmitCardRepo(context);

        private ISalary salary;
        public ISalary SalaryRepo => salary ??= new SalaryRepo(context);

        private ISchool school;
        public ISchool SchoolRepo => school ??= new SchoolRepo(context);

        private ISchoolClass schoolClass;
        public ISchoolClass SchoolClassRepo => schoolClass ??= new SchoolClassRepo(context);

        private ISection section;
        public ISection SectionRepo => section ??= new SectionRepo(context);

        private IStaff staff;
        public IStaff StaffRepo => staff ??= new StaffRepo(context);

        private IStaffAttendance staffAttendance;
        public IStaffAttendance StaffAttendanceRepo => staffAttendance ??= new StaffAttendanceRepo(context);

        private IStudent student;
        public IStudent StudentRepo => student ??= new StudentRepo(context);

        private ISubject subject;
        public ISubject SubjectRepo => subject ??= new SubjectRepo(context);

        private ISubstituteAssignment substituteAssignment;
        public ISubstituteAssignment SubstituteAssignmentRepo => substituteAssignment ??= new SubstituteAssignmentRepo(context);

        private ITeacher teacher;
        public ITeacher TeacherRepo => teacher ??= new TeacherRepo(context);

        private ITimetableEntry timetableEntry;
        public ITimetableEntry TimetableEntryRepo => timetableEntry ??= new TimetableEntryRepo(context);

        private ITransaction transaction;
        public ITransaction TransactionRepo => transaction ??= new TransactionRepo(context);

        private ISchoolClassSubject schoolClassSubject;
        public ISchoolClassSubject SchoolClassSubjectRepo => schoolClassSubject ??= new SchoolClassSubjectRepo(context);
        private IAttendance attendance;
        public IAttendance AttendanceRepo => attendance ??= new AttendanceRepo(context);

        private IBranch branch;
        public IBranch BranchRepo => branch ??= new BranchRepo(context);

        private IClassSubject classSubject;
        public IClassSubject ClassSubjectRepo => classSubject ??= new ClassSubjectRepo(context);

        private IEvent @event;
        public IEvent EventRepo => @event ??= new EventRepo(context);

        private IEventImage eventImage;
        public IEventImage EventImageRepo => eventImage ??= new EventImageRepo(context);

        private IExam exam;
        public IExam ExamRepo => exam ??= new ExamRepo(context);

        private IExamRoutine examRoutine;
        public IExamRoutine ExamRoutineRepo => examRoutine ??= new ExamRoutineRepo(context);

        private IFee fee;
        public IFee FeeRepo => fee ??= new FeeRepo(context);

        private IFeedback feedback;
        public IFeedback FeedbackRepo => feedback ??= new FeedbackRepo(context);

        private IFeePayment feePayment;
        public IFeePayment FeePaymentRepo => feePayment ??= new FeePaymentRepo(context);

        public IFeeStructure feeStructure;
        public IFeeStructure FeeStructureRepo => feeStructure ??= new FeeStructureRepo(context);

        public IHomework homework;
        public IHomework HomeworkRepo => homework ??= new HomeworkRepo(context);

        public IHomeworkSubmission homeworkSubmission;
        public IHomeworkSubmission HomeworkSubmissionRepo => homeworkSubmission ??= new HomeworkSubmissionRepo(context);

        public IIDCard iDCard;
        public IIDCard IDCardRepo => iDCard ??= new IDCardRepo(context);

        public ILeaveRequest leaveRequest;
        public ILeaveRequest LeaveRequestRepo => leaveRequest ??= new LeaveRequestRepo(context);

        public IMessage message;
        public IMessage MessageRepo => message ??= new MessageRepo(context);

        public INotice notice;
        public INotice NoticeRepo => notice ??= new NoticeRepo(context);

        public INotification notification;
        public INotification NotificationRepo => notification ??= new NotificationRepo(context);

        public IParent parent;
        public IParent ParentRepo => parent ??= new ParentRepo(context);

        public IResult result;
        public IResult ResultRepo => result ??= new ResultRepo(context);


        public Modelmessage Save()
        {
            Modelmessage modelMessage = new Modelmessage();
            try
            {
                if (context.SaveChanges() > 0)
                {
                    modelMessage.Message = $"Operation successful";
                    modelMessage.IsSucces = true;
                }
                else
                {
                    modelMessage.Message = $"Operation Failled ";
                    modelMessage.IsSucces = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    modelMessage.Message = ex.InnerException.Message;
                    modelMessage.IsSucces = false;
                }
                else
                {
                    modelMessage.Message = ex.Message;
                    modelMessage.IsSucces = false;
                }
            }
            return modelMessage;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

    }
}
