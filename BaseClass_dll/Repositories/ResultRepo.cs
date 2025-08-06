using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IResult : IBaseRepo<Result> { }

    public class ResultRepo : BaseRepo<Result>, IResult
    {
        public ResultRepo(ApplicationDbContext context) : base(context) { }
    }
}
