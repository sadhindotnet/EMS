using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IStudent : IBaseRepo<Student> { }


    public class StudentRepo : BaseRepo<Student>, IStudent
    {
        public StudentRepo(ApplicationDbContext context) : base(context) { }
    }
}
