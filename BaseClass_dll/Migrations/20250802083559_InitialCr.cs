using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseClass_dll.Migrations
{
    /// <inheritdoc />
    public partial class InitialCr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_AbsentTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_AdmitCard_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ApprovedBy",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_EventId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeePayment_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeeStructureId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeeStructure_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Fee_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_HomeworkId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_HomeworkSubmission_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_IDCard_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_LeaveRequest_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Notification_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ParentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Parent_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_ReceiverId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Salary_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClassSubject_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClass_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClass_SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Section_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SenderId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_StaffAttendance_StaffId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_StaffId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Staff_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_SubstituteTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_Teacher_UserId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntryId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntities_BaseEntities_UserId",
                table: "BaseEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_AbsentTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_AdmitCard_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ApprovedBy",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_EventId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ExamRoutine_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ExamRoutine_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ExamRoutine_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Fee_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_FeePayment_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_FeeStructure_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_FeeStructureId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Homework_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Homework_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Homework_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_HomeworkId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_HomeworkSubmission_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_IDCard_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_LeaveRequest_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Notification_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Parent_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ParentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_ReceiverId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Result_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Result_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Result_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Salary_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SchoolClass_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SchoolClass_SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SchoolClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SchoolClassSubject_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Section_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SenderId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Staff_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_StaffAttendance_StaffId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_StaffId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Student_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Student_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Student_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_SubstituteTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_Teacher_UserId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TimetableEntry_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TimetableEntry_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TimetableEntry_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TimetableEntry_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_TimetableEntryId",
                table: "BaseEntities");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntities_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AbsentTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AdmissionDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AdmitCardPath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AdmitCard_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Allowance",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "BasicSalary",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Body",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "CustomName",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ExamDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ExamRoutine_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ExamRoutine_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ExamRoutine_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Exam_Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FeePayment_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FeeStructureId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FeeStructure_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FeeStructure_Amount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FeeType",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Fee_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "HeadOffice",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "HomeworkId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "HomeworkSubmission_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Homework_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Homework_Description",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Homework_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Homework_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Homework_Title",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IDCardPath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IDCard_IssuedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IDCard_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IFromFilePaths",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IsPresent",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IsSalaryDeducted",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "IssuedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "LeaveDeduction",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "LeaveRequest_EndDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "LeaveRequest_StartDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "LeaveRequest_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "LeaveType",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "MarksObtained",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "NIDNumber",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Notice_Body",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Notice_TargetAudience",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Notice_Title",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Notification_Message",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Notification_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "OvertimeAmount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PaidAmount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Parent_Address",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Parent_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PassMarks",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PermittedLeaveDays",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PreviousSchool",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PrintCount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "ReceiverUserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Result_ExamId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Result_StudentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Result_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "RollNumber",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Salary_PaymentDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Salary_PaymentMethod",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Salary_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SchoolClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SchoolClassSubject_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SchoolClass_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SchoolClass_SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "School_Address",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "School_Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Section_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Section_Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SenderUserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SentAt",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StaffAttendance_Date",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StaffAttendance_IsPresent",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StaffAttendance_StaffId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Staff_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Student_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Student_Address",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Student_PhotoPath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Student_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Student_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Subject_Name",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SubmittedAt",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SubmittedDate",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SubstituteAssignment_Date",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "SubstituteTeacherId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TargetAudience",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TaxDeduction",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Teacher_Designation",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Teacher_NIDNumber",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Teacher_PhotoPath",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Teacher_UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntryId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_AcademyClassId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_EndTime",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_SectionId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_StartTime",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_SubjectId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TimetableEntry_TeacherId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TotalLeaveDays",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TotalMarks",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Transaction_Amount",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Transaction_Category",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Transaction_Date",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Transaction_Description",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "User_CreatedAt",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "BaseEntities");

            migrationBuilder.RenameTable(
                name: "BaseEntities",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AcademyClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetAudience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IDCardPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrintCount = table.Column<int>(type: "int", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderUserId = table.Column<int>(type: "int", nullable: false),
                    ReceiverUserId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetAudience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OvertimeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PermittedLeaveDays = table.Column<int>(type: "int", nullable: false),
                    TotalLeaveDays = table.Column<int>(type: "int", nullable: false),
                    TaxDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salaries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fees_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeeStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeStructures_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventImages_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadOffice = table.Column<bool>(type: "bit", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    CustomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClasses_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    IsSalaryDeducted = table.Column<bool>(type: "bit", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAttendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffAttendances_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homeworks_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homeworks_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamRoutines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRoutines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RollNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    PreviousSchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TimetableEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimetableEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolClassSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolClassSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolClassSubjects_SchoolClasses_SchoolClassId",
                        column: x => x.SchoolClassId,
                        principalTable: "SchoolClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolClassSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AdmitCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    AdmitCardPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmitCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdmitCards_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AdmitCards_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "FeePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    FeeStructureId = table.Column<int>(type: "int", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeePayments_FeeStructures_FeeStructureId",
                        column: x => x.FeeStructureId,
                        principalTable: "FeeStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeePayments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HomeworkSubmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeworkId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFromFilePaths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkSubmissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeworkSubmissions_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HomeworkSubmissions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    TotalMarks = table.Column<double>(type: "float", nullable: false),
                    PassMarks = table.Column<double>(type: "float", nullable: false),
                    MarksObtained = table.Column<double>(type: "float", nullable: false),
                    GPA = table.Column<double>(type: "float", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Results_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Results_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubstituteAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimetableEntryId = table.Column<int>(type: "int", nullable: false),
                    AbsentTeacherId = table.Column<int>(type: "int", nullable: false),
                    SubstituteTeacherId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubstituteAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubstituteAssignments_Teachers_AbsentTeacherId",
                        column: x => x.AbsentTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubstituteAssignments_Teachers_SubstituteTeacherId",
                        column: x => x.SubstituteTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubstituteAssignments_TimetableEntries_TimetableEntryId",
                        column: x => x.TimetableEntryId,
                        principalTable: "TimetableEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmitCards_ExamId",
                table: "AdmitCards",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_AdmitCards_StudentId",
                table: "AdmitCards",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_SchoolId",
                table: "Branches",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_AcademyClassId",
                table: "ClassSubjects",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_SubjectId",
                table: "ClassSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_TeacherId",
                table: "ClassSubjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_EventImages_EventId",
                table: "EventImages",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_AcademyClassId",
                table: "ExamRoutines",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_ExamId",
                table: "ExamRoutines",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_SectionId",
                table: "ExamRoutines",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_SubjectId",
                table: "ExamRoutines",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FeePayments_FeeStructureId",
                table: "FeePayments",
                column: "FeeStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeePayments_StudentId",
                table: "FeePayments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fees_AcademyClassId",
                table: "Fees",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeStructures_AcademyClassId",
                table: "FeeStructures",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_AcademyClassId",
                table: "Homeworks",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_SubjectId",
                table: "Homeworks",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_TeacherId",
                table: "Homeworks",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_HomeworkId",
                table: "HomeworkSubmissions",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_IdCards_UserId",
                table: "IdCards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApprovedBy",
                table: "LeaveRequests",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_StaffId",
                table: "LeaveRequests",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_UserId",
                table: "LeaveRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_ExamId",
                table: "Results",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentId",
                table: "Results",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_SubjectId",
                table: "Results",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_UserId",
                table: "Salaries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_AcademyClassId",
                table: "SchoolClasses",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClasses_SchoolId",
                table: "SchoolClasses",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassSubjects_SchoolClassId",
                table: "SchoolClassSubjects",
                column: "SchoolClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolClassSubjects_SubjectId",
                table: "SchoolClassSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_AcademyClassId",
                table: "Sections",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendances_StaffId",
                table: "StaffAttendances",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AcademyClassId",
                table: "Students",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SectionId",
                table: "Students",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubstituteAssignments_AbsentTeacherId",
                table: "SubstituteAssignments",
                column: "AbsentTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstituteAssignments_SubstituteTeacherId",
                table: "SubstituteAssignments",
                column: "SubstituteTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubstituteAssignments_TimetableEntryId",
                table: "SubstituteAssignments",
                column: "TimetableEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_AcademyClassId",
                table: "TimetableEntries",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_SectionId",
                table: "TimetableEntries",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_SubjectId",
                table: "TimetableEntries",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_TeacherId",
                table: "TimetableEntries",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmitCards");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "ClassSubjects");

            migrationBuilder.DropTable(
                name: "EventImages");

            migrationBuilder.DropTable(
                name: "ExamRoutines");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FeePayments");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "HomeworkSubmissions");

            migrationBuilder.DropTable(
                name: "IdCards");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "SchoolClassSubjects");

            migrationBuilder.DropTable(
                name: "StaffAttendances");

            migrationBuilder.DropTable(
                name: "SubstituteAssignments");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FeeStructures");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SchoolClasses");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "TimetableEntries");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AcademyClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "BaseEntities");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "AbsentTeacherId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AdmissionDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdmitCardPath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdmitCard_StudentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Allowance",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovedBy",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BasicSalary",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Bonus",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomName",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntities",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "BaseEntities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EventDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamRoutine_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamRoutine_ExamId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamRoutine_SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exam_Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeePayment_StudentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeeStructureId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeeStructure_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "FeeStructure_Amount",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeeType",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fee_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GPA",
                table: "BaseEntities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HeadOffice",
                table: "BaseEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeworkId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeworkSubmission_StudentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Homework_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Homework_Description",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Homework_SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Homework_TeacherId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Homework_Title",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IDCardPath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IDCard_IssuedDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDCard_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IFromFilePaths",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPresent",
                table: "BaseEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "BaseEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSalaryDeducted",
                table: "BaseEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IssuedDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaveDeduction",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeaveRequest_EndDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LeaveRequest_StartDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeaveRequest_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaveType",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MarksObtained",
                table: "BaseEntities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NIDNumber",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notice_Body",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notice_TargetAudience",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notice_Title",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notification_Message",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Notification_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OvertimeAmount",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PaidAmount",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parent_Address",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Parent_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PassMarks",
                table: "BaseEntities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PermittedLeaveDays",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousSchool",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrintCount",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverUserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result_ExamId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result_StudentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result_SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RollNumber",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Salary_PaymentDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salary_PaymentMethod",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolClassSubject_SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolClass_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolClass_SchoolId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "School_Address",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "School_Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Section_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Section_Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderUserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SentAt",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StaffAttendance_Date",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StaffAttendance_IsPresent",
                table: "BaseEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffAttendance_StaffId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Staff_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "BaseEntities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Student_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_Address",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_PhotoPath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Student_SectionId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Student_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject_Name",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmittedAt",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmittedDate",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubstituteAssignment_Date",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubstituteTeacherId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetAudience",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxDeduction",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_Designation",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_NIDNumber",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Teacher_PhotoPath",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Teacher_UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimetableEntryId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimetableEntry_AcademyClassId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimetableEntry_EndTime",
                table: "BaseEntities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimetableEntry_SectionId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimetableEntry_StartTime",
                table: "BaseEntities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimetableEntry_SubjectId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimetableEntry_TeacherId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalLeaveDays",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalMarks",
                table: "BaseEntities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Transaction_Amount",
                table: "BaseEntities",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transaction_Category",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Transaction_Date",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transaction_Description",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "BaseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "User_CreatedAt",
                table: "BaseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "BaseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_AbsentTeacherId",
                table: "BaseEntities",
                column: "AbsentTeacherId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_AcademyClassId",
                table: "BaseEntities",
                column: "AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_AdmitCard_StudentId",
                table: "BaseEntities",
                column: "AdmitCard_StudentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ApprovedBy",
                table: "BaseEntities",
                column: "ApprovedBy",
                principalTable: "BaseEntities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_EventId",
                table: "BaseEntities",
                column: "EventId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamId",
                table: "BaseEntities",
                column: "ExamId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_AcademyClassId",
                table: "BaseEntities",
                column: "ExamRoutine_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_ExamId",
                table: "BaseEntities",
                column: "ExamRoutine_ExamId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ExamRoutine_SubjectId",
                table: "BaseEntities",
                column: "ExamRoutine_SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeePayment_StudentId",
                table: "BaseEntities",
                column: "FeePayment_StudentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeeStructureId",
                table: "BaseEntities",
                column: "FeeStructureId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_FeeStructure_AcademyClassId",
                table: "BaseEntities",
                column: "FeeStructure_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Fee_AcademyClassId",
                table: "BaseEntities",
                column: "Fee_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_HomeworkId",
                table: "BaseEntities",
                column: "HomeworkId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_HomeworkSubmission_StudentId",
                table: "BaseEntities",
                column: "HomeworkSubmission_StudentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_AcademyClassId",
                table: "BaseEntities",
                column: "Homework_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_SubjectId",
                table: "BaseEntities",
                column: "Homework_SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Homework_TeacherId",
                table: "BaseEntities",
                column: "Homework_TeacherId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_IDCard_UserId",
                table: "BaseEntities",
                column: "IDCard_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_LeaveRequest_UserId",
                table: "BaseEntities",
                column: "LeaveRequest_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Notification_UserId",
                table: "BaseEntities",
                column: "Notification_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ParentId",
                table: "BaseEntities",
                column: "ParentId",
                principalTable: "BaseEntities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Parent_UserId",
                table: "BaseEntities",
                column: "Parent_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_ReceiverId",
                table: "BaseEntities",
                column: "ReceiverId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_ExamId",
                table: "BaseEntities",
                column: "Result_ExamId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_StudentId",
                table: "BaseEntities",
                column: "Result_StudentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Result_SubjectId",
                table: "BaseEntities",
                column: "Result_SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Salary_UserId",
                table: "BaseEntities",
                column: "Salary_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClassId",
                table: "BaseEntities",
                column: "SchoolClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClassSubject_SubjectId",
                table: "BaseEntities",
                column: "SchoolClassSubject_SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClass_AcademyClassId",
                table: "BaseEntities",
                column: "SchoolClass_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolClass_SchoolId",
                table: "BaseEntities",
                column: "SchoolClass_SchoolId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SchoolId",
                table: "BaseEntities",
                column: "SchoolId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SectionId",
                table: "BaseEntities",
                column: "SectionId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Section_AcademyClassId",
                table: "BaseEntities",
                column: "Section_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SenderId",
                table: "BaseEntities",
                column: "SenderId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_StaffAttendance_StaffId",
                table: "BaseEntities",
                column: "StaffAttendance_StaffId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_StaffId",
                table: "BaseEntities",
                column: "StaffId",
                principalTable: "BaseEntities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Staff_UserId",
                table: "BaseEntities",
                column: "Staff_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_StudentId",
                table: "BaseEntities",
                column: "StudentId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_AcademyClassId",
                table: "BaseEntities",
                column: "Student_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_SectionId",
                table: "BaseEntities",
                column: "Student_SectionId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Student_UserId",
                table: "BaseEntities",
                column: "Student_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SubjectId",
                table: "BaseEntities",
                column: "SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_SubstituteTeacherId",
                table: "BaseEntities",
                column: "SubstituteTeacherId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TeacherId",
                table: "BaseEntities",
                column: "TeacherId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_Teacher_UserId",
                table: "BaseEntities",
                column: "Teacher_UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntryId",
                table: "BaseEntities",
                column: "TimetableEntryId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_AcademyClassId",
                table: "BaseEntities",
                column: "TimetableEntry_AcademyClassId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_SectionId",
                table: "BaseEntities",
                column: "TimetableEntry_SectionId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_SubjectId",
                table: "BaseEntities",
                column: "TimetableEntry_SubjectId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_TimetableEntry_TeacherId",
                table: "BaseEntities",
                column: "TimetableEntry_TeacherId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntities_BaseEntities_UserId",
                table: "BaseEntities",
                column: "UserId",
                principalTable: "BaseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
