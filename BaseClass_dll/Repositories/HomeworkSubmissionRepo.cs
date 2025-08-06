using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IHomeworkSubmission : IBaseRepo<HomeworkSubmission> { }
    public class HomeworkSubmissionRepo : BaseRepo<HomeworkSubmission>, IHomeworkSubmission
    {
        public HomeworkSubmissionRepo(ApplicationDbContext context) : base(context) { }
    }
}
