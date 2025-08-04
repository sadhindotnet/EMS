using System.Security.Claims;

 namespace BaseClass_dll
    {
        public class Fee : BaseEntity
    {
            public string CategoryName { get; set; }  
            public decimal Amount { get; set; }    
            public int AcademyClassId { get; set; }
            public AcademyClass AcademyClass { get; set; }
        }
   }

