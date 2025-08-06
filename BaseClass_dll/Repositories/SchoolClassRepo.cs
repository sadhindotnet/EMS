using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISchoolClass : IBaseRepo<SchoolClass> { }


    public class SchoolClassRepo : BaseRepo<SchoolClass>, ISchoolClass
    {
        public SchoolClassRepo(ApplicationDbContext context) : base(context) { }
    }
}
