using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IStaff : IBaseRepo<Staff> { }


    public class StaffRepo : BaseRepo<Staff>, IStaff
    {
        public StaffRepo(ApplicationDbContext context) : base(context) { }
    }
}
