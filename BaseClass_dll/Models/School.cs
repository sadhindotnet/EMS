using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        [ValidateNever]
        public ICollection<Branch>? Branches { get; set; }
        [ValidateNever]
        public ICollection<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();

    }
}
