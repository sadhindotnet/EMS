using BaseClass_dll;
using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using BaseClass_dll.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUser, UserRepo>();
builder.Services.AddScoped<IAcademyClass, AcademyClassRepo>();
builder.Services.AddScoped<IAdmitCard,AdmitCardRepo>();
builder.Services.AddScoped<ISalary, SalaryRepo>();
builder.Services.AddScoped<ISchool, SchoolRepo>();
builder.Services.AddScoped<ISchoolClass, SchoolClassRepo>();
builder.Services.AddScoped<ISection, SectionRepo>();
builder.Services.AddScoped<IStaff, StaffRepo>();
builder.Services.AddScoped<IStaffAttendance, StaffAttendanceRepo>();
builder.Services.AddScoped<ISubstituteAssignment, SubstituteAssignmentRepo>();
builder.Services.AddScoped<ITeacher, TeacherRepo>();
builder.Services.AddScoped<ITimetableEntry, TimetableEntryRepo>();
builder.Services.AddScoped<ITransaction, TransactionRepo>();
builder.Services.AddScoped<ISchoolClassSubject, SchoolClassSubjectRepo>();
builder.Services.AddScoped<IAttendance, AttendanceRepo>();
builder.Services.AddScoped<IBranch, BranchRepo>();
builder.Services.AddScoped<IClassSubject, ClassSubjectRepo>();
builder.Services.AddScoped<IEvent, EventRepo>();
builder.Services.AddScoped<IEventImage, EventImageRepo>();
builder.Services.AddScoped<IExam, ExamRepo>();
builder.Services.AddScoped<IExamRoutine, ExamRoutineRepo>();
builder.Services.AddScoped<IFee, FeeRepo>();
builder.Services.AddScoped<IFeedback, FeedbackRepo>();
builder.Services.AddScoped<IFeePayment, FeePaymentRepo>();
builder.Services.AddScoped<IFeeStructure, FeeStructureRepo>();
builder.Services.AddScoped<IHomework, HomeworkRepo>();
builder.Services.AddScoped<IHomeworkSubmission, HomeworkSubmissionRepo>();
builder.Services.AddScoped<IIDCard, IDCardRepo>();
builder.Services.AddScoped<ILeaveRequest, LeaveRequestRepo>();
builder.Services.AddScoped<IMessage, MessageRepo>();
builder.Services.AddScoped<INotice, NoticeRepo>();
builder.Services.AddScoped<INotification, NotificationRepo>();
builder.Services.AddScoped<IParent, ParentRepo>();







builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
//app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); 
app.UseAuthentication(); 
app.UseAuthorization();  

app.MapControllers();

app.Run();
