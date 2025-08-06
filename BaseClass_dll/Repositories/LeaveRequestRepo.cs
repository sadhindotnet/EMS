using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ILeaveRequest : IBaseRepo<LeaveRequest> { }
    public class LeaveRequestRepo : BaseRepo<LeaveRequest>, ILeaveRequest
    {
        public LeaveRequestRepo(ApplicationDbContext context) : base(context) { }
    }
}
