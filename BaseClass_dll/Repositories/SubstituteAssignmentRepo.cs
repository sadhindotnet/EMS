using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ISubstituteAssignment : IBaseRepo<SubstituteAssignment> { }


    public class SubstituteAssignmentRepo : BaseRepo<SubstituteAssignment>, ISubstituteAssignment
    {
        public SubstituteAssignmentRepo(ApplicationDbContext context) : base(context) { }
    }
}
