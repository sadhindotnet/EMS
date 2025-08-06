using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IExam : IBaseRepo<Exam> { }


    public class ExamRepo : BaseRepo<Exam>, IExam
    {
        public ExamRepo(ApplicationDbContext context) : base(context) { }
    }
}
