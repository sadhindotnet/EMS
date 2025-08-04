using System.Security.Claims;

namespace BaseClass_dll
{
    public class ClassSubject : BaseEntity
    {
        public int AcademyClassId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public AcademyClass AcademyClass { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }

}
