using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaseClass_dll
{
    public class Branch : BaseEntity
    {
        public string Address { get; set; }
        public bool HeadOffice { get; set; }//ektai headCoffice hobe 1 tai
        public int SchoolId { get; set; }
        [ValidateNever]
        public School School { get; set; }
    }
}
