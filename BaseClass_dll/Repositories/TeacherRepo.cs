using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ITeacher : IBaseRepo<Teacher> { }


    public class TeacherRepo : BaseRepo<Teacher>, ITeacher
    {
        public TeacherRepo(ApplicationDbContext context) : base(context) { }
    }
}
