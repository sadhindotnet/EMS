using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IBranch : IBaseRepo<Branch> { }


    public class BranchRepo : BaseRepo<Branch>, IBranch
    {
        public BranchRepo(ApplicationDbContext context) : base(context) { }
    }
}
