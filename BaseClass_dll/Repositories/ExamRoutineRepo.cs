using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IExamRoutine : IBaseRepo<ExamRoutine> { }


    public class ExamRoutineRepo : BaseRepo<ExamRoutine>, IExamRoutine
    {
        public ExamRoutineRepo(ApplicationDbContext context) : base(context) { }
    }
}
