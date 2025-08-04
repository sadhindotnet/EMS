using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IAcademyClass : IBaseRepo<AcademyClass> { }


    public class AcademyClassRepo : BaseRepo<AcademyClass>, IAcademyClass
    {
        public AcademyClassRepo(ApplicationDbContext context) : base(context) { }
    }
    
}
