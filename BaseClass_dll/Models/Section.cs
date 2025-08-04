using System.Security.Claims;

namespace BaseClass_dll
{
    public class Section : BaseEntity
    {
        public string Name { get; set; } // e.g., "A", "B"

        public int AcademyClassId { get; set; }
        public AcademyClass AcademyClass { get; set; }
    }

}
