using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseClass_dll.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmitCard_StudentId = table.Column<int>(type: "int", nullable: true),
                    ExamId = table.Column<int>(type: "int", nullable: true),
                    AdmitCardPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPresent = table.Column<bool>(type: "bit", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadOffice = table.Column<bool>(type: "bit", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetAudience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exam_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamRoutine_ExamId = table.Column<int>(type: "int", nullable: true),
                    ExamRoutine_SubjectId = table.Column<int>(type: "int", nullable: true),
                    ExamRoutine_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    SectionId = table.Column<int>(type: "int", nullable: true),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fee_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    FeePayment_StudentId = table.Column<int>(type: "int", nullable: true),
                    FeeStructureId = table.Column<int>(type: "int", nullable: true),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeeStructure_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FeeStructure_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Homework_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    Homework_SubjectId = table.Column<int>(type: "int", nullable: true),
                    Homework_TeacherId = table.Column<int>(type: "int", nullable: true),
                    Homework_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Homework_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HomeworkId = table.Column<int>(type: "int", nullable: true),
                    HomeworkSubmission_StudentId = table.Column<int>(type: "int", nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IFromFilePaths = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCard_UserId = table.Column<int>(type: "int", nullable: true),
                    IDCardPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintCount = table.Column<int>(type: "int", nullable: true),
                    IDCard_IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveRequest_UserId = table.Column<int>(type: "int", nullable: true),
                    LeaveRequest_StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveRequest_EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    IsSalaryDeducted = table.Column<bool>(type: "bit", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    SenderUserId = table.Column<int>(type: "int", nullable: true),
                    ReceiverUserId = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    Notice_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notice_Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notice_TargetAudience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notification_UserId = table.Column<int>(type: "int", nullable: true),
                    Notification_Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Parent_UserId = table.Column<int>(type: "int", nullable: true),
                    NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result_StudentId = table.Column<int>(type: "int", nullable: true),
                    Result_SubjectId = table.Column<int>(type: "int", nullable: true),
                    Result_ExamId = table.Column<int>(type: "int", nullable: true),
                    TotalMarks = table.Column<double>(type: "float", nullable: true),
                    PassMarks = table.Column<double>(type: "float", nullable: true),
                    MarksObtained = table.Column<double>(type: "float", nullable: true),
                    GPA = table.Column<double>(type: "float", nullable: true),
                    Salary_UserId = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OvertimeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PermittedLeaveDays = table.Column<int>(type: "int", nullable: true),
                    TotalLeaveDays = table.Column<int>(type: "int", nullable: true),
                    TaxDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LeaveDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Salary_PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolClass_SchoolId = table.Column<int>(type: "int", nullable: true),
                    SchoolClass_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    CustomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolClassId = table.Column<int>(type: "int", nullable: true),
                    SchoolClassSubject_SubjectId = table.Column<int>(type: "int", nullable: true),
                    Section_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    Staff_UserId = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffAttendance_StaffId = table.Column<int>(type: "int", nullable: true),
                    StaffAttendance_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StaffAttendance_IsPresent = table.Column<bool>(type: "bit", nullable: true),
                    Student_UserId = table.Column<int>(type: "int", nullable: true),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Student_PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Student_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Student_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    Student_SectionId = table.Column<int>(type: "int", nullable: true),
                    PreviousSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Subject_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimetableEntryId = table.Column<int>(type: "int", nullable: true),
                    AbsentTeacherId = table.Column<int>(type: "int", nullable: true),
                    SubstituteTeacherId = table.Column<int>(type: "int", nullable: true),
                    SubstituteAssignment_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Teacher_UserId = table.Column<int>(type: "int", nullable: true),
                    Teacher_NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teacher_Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teacher_PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimetableEntry_AcademyClassId = table.Column<int>(type: "int", nullable: true),
                    TimetableEntry_SectionId = table.Column<int>(type: "int", nullable: true),
                    TimetableEntry_SubjectId = table.Column<int>(type: "int", nullable: true),
                    TimetableEntry_TeacherId = table.Column<int>(type: "int", nullable: true),
                    DayOfWeek = table.Column<int>(type: "int", nullable: true),
                    TimetableEntry_StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    TimetableEntry_EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Transaction_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AbsentTeacherId",
                        column: x => x.AbsentTeacherId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_AdmitCard_StudentId",
                        column: x => x.AdmitCard_StudentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_EventId",
                        column: x => x.EventId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ExamId",
                        column: x => x.ExamId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ExamRoutine_AcademyClassId",
                        column: x => x.ExamRoutine_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ExamRoutine_ExamId",
                        column: x => x.ExamRoutine_ExamId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ExamRoutine_SubjectId",
                        column: x => x.ExamRoutine_SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_FeePayment_StudentId",
                        column: x => x.FeePayment_StudentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_FeeStructureId",
                        column: x => x.FeeStructureId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_FeeStructure_AcademyClassId",
                        column: x => x.FeeStructure_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Fee_AcademyClassId",
                        column: x => x.Fee_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_HomeworkSubmission_StudentId",
                        column: x => x.HomeworkSubmission_StudentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Homework_AcademyClassId",
                        column: x => x.Homework_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Homework_SubjectId",
                        column: x => x.Homework_SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Homework_TeacherId",
                        column: x => x.Homework_TeacherId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_IDCard_UserId",
                        column: x => x.IDCard_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_LeaveRequest_UserId",
                        column: x => x.LeaveRequest_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Notification_UserId",
                        column: x => x.Notification_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Parent_UserId",
                        column: x => x.Parent_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Result_ExamId",
                        column: x => x.Result_ExamId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Result_StudentId",
                        column: x => x.Result_StudentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Result_SubjectId",
                        column: x => x.Result_SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Salary_UserId",
                        column: x => x.Salary_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SchoolClassId",
                        column: x => x.SchoolClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SchoolClassSubject_SubjectId",
                        column: x => x.SchoolClassSubject_SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SchoolClass_AcademyClassId",
                        column: x => x.SchoolClass_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SchoolClass_SchoolId",
                        column: x => x.SchoolClass_SchoolId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SectionId",
                        column: x => x.SectionId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Section_AcademyClassId",
                        column: x => x.Section_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SenderId",
                        column: x => x.SenderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_StaffAttendance_StaffId",
                        column: x => x.StaffAttendance_StaffId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_StaffId",
                        column: x => x.StaffId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Staff_UserId",
                        column: x => x.Staff_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_StudentId",
                        column: x => x.StudentId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Student_AcademyClassId",
                        column: x => x.Student_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Student_SectionId",
                        column: x => x.Student_SectionId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Student_UserId",
                        column: x => x.Student_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SubstituteTeacherId",
                        column: x => x.SubstituteTeacherId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Teacher_UserId",
                        column: x => x.Teacher_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TimetableEntryId",
                        column: x => x.TimetableEntryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TimetableEntry_AcademyClassId",
                        column: x => x.TimetableEntry_AcademyClassId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TimetableEntry_SectionId",
                        column: x => x.TimetableEntry_SectionId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TimetableEntry_SubjectId",
                        column: x => x.TimetableEntry_SubjectId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_TimetableEntry_TeacherId",
                        column: x => x.TimetableEntry_TeacherId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AbsentTeacherId",
                table: "BaseEntities",
                column: "AbsentTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AcademyClassId",
                table: "BaseEntities",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_AdmitCard_StudentId",
                table: "BaseEntities",
                column: "AdmitCard_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ApprovedBy",
                table: "BaseEntities",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_EventId",
                table: "BaseEntities",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ExamId",
                table: "BaseEntities",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ExamRoutine_AcademyClassId",
                table: "BaseEntities",
                column: "ExamRoutine_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ExamRoutine_ExamId",
                table: "BaseEntities",
                column: "ExamRoutine_ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ExamRoutine_SubjectId",
                table: "BaseEntities",
                column: "ExamRoutine_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Fee_AcademyClassId",
                table: "BaseEntities",
                column: "Fee_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_FeePayment_StudentId",
                table: "BaseEntities",
                column: "FeePayment_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_FeeStructure_AcademyClassId",
                table: "BaseEntities",
                column: "FeeStructure_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_FeeStructureId",
                table: "BaseEntities",
                column: "FeeStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Homework_AcademyClassId",
                table: "BaseEntities",
                column: "Homework_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Homework_SubjectId",
                table: "BaseEntities",
                column: "Homework_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Homework_TeacherId",
                table: "BaseEntities",
                column: "Homework_TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_HomeworkId",
                table: "BaseEntities",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_HomeworkSubmission_StudentId",
                table: "BaseEntities",
                column: "HomeworkSubmission_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_IDCard_UserId",
                table: "BaseEntities",
                column: "IDCard_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_LeaveRequest_UserId",
                table: "BaseEntities",
                column: "LeaveRequest_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Notification_UserId",
                table: "BaseEntities",
                column: "Notification_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Parent_UserId",
                table: "BaseEntities",
                column: "Parent_UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ParentId",
                table: "BaseEntities",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ReceiverId",
                table: "BaseEntities",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Result_ExamId",
                table: "BaseEntities",
                column: "Result_ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Result_StudentId",
                table: "BaseEntities",
                column: "Result_StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Result_SubjectId",
                table: "BaseEntities",
                column: "Result_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Salary_UserId",
                table: "BaseEntities",
                column: "Salary_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SchoolClass_AcademyClassId",
                table: "BaseEntities",
                column: "SchoolClass_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SchoolClass_SchoolId",
                table: "BaseEntities",
                column: "SchoolClass_SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SchoolClassId",
                table: "BaseEntities",
                column: "SchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SchoolClassSubject_SubjectId",
                table: "BaseEntities",
                column: "SchoolClassSubject_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SchoolId",
                table: "BaseEntities",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Section_AcademyClassId",
                table: "BaseEntities",
                column: "Section_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SectionId",
                table: "BaseEntities",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SenderId",
                table: "BaseEntities",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Staff_UserId",
                table: "BaseEntities",
                column: "Staff_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_StaffAttendance_StaffId",
                table: "BaseEntities",
                column: "StaffAttendance_StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_StaffId",
                table: "BaseEntities",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Student_AcademyClassId",
                table: "BaseEntities",
                column: "Student_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Student_SectionId",
                table: "BaseEntities",
                column: "Student_SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Student_UserId",
                table: "BaseEntities",
                column: "Student_UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_StudentId",
                table: "BaseEntities",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SubjectId",
                table: "BaseEntities",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SubstituteTeacherId",
                table: "BaseEntities",
                column: "SubstituteTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Teacher_UserId",
                table: "BaseEntities",
                column: "Teacher_UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TeacherId",
                table: "BaseEntities",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TimetableEntry_AcademyClassId",
                table: "BaseEntities",
                column: "TimetableEntry_AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TimetableEntry_SectionId",
                table: "BaseEntities",
                column: "TimetableEntry_SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TimetableEntry_SubjectId",
                table: "BaseEntities",
                column: "TimetableEntry_SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TimetableEntry_TeacherId",
                table: "BaseEntities",
                column: "TimetableEntry_TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_TimetableEntryId",
                table: "BaseEntities",
                column: "TimetableEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_UserId",
                table: "BaseEntities",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BaseEntities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
