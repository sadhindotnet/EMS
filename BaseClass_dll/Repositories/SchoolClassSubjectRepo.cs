using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISchoolClassSubject : IBaseRepo<SchoolClassSubject> { }


    public class SchoolClassSubjectRepo : BaseRepo<SchoolClassSubject>, ISchoolClassSubject
    {
        public SchoolClassSubjectRepo(ApplicationDbContext context) : base(context) { }
    }
}
