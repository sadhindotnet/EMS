using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IClassSubject : IBaseRepo<ClassSubject> { }


    public class ClassSubjectRepo : BaseRepo<ClassSubject>, IClassSubject
    {
        public ClassSubjectRepo(ApplicationDbContext context) : base(context) { }
    }
}
