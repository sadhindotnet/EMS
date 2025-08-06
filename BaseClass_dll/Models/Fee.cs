using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Security.Claims;

 namespace BaseClass_dll
    {
        public class Fee : BaseEntity
    {
            public string CategoryName { get; set; }  
            public decimal Amount { get; set; }    
            public int AcademyClassId { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        }
   }

