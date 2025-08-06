using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISchool : IBaseRepo<School> { }


    public class SchoolRepo : BaseRepo<School>, ISchool
    {
        public SchoolRepo(ApplicationDbContext context) : base(context) { }
    }
    
}
