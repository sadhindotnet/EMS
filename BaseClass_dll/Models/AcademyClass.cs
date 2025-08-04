using static System.Collections.Specialized.BitVector32;

namespace BaseClass_dll
{
    public class AcademyClass : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();
        public ICollection<Section> Sections { get; set; }
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
