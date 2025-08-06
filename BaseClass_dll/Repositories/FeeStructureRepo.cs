using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IFeeStructure : IBaseRepo<FeeStructure> { }
    public class FeeStructureRepo : BaseRepo<FeeStructure>, IFeeStructure
    {
        public FeeStructureRepo(ApplicationDbContext context) : base(context) { }
    }
}
