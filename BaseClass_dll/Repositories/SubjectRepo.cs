using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISubject : IBaseRepo<Subject> { }


    public class SubjectRepo : BaseRepo<Subject>, ISubject
    {
        public SubjectRepo(ApplicationDbContext context) : base(context) { }
    }
}
