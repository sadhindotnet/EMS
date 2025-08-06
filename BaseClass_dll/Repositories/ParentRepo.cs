using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IParent : IBaseRepo<Parent> { }

    public class ParentRepo : BaseRepo<Parent>, IParent
    {
        public ParentRepo(ApplicationDbContext context) : base(context) { }
    }
}
