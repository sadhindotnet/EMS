using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IStaffAttendance : IBaseRepo<StaffAttendance> { }


    public class StaffAttendanceRepo : BaseRepo<StaffAttendance>, IStaffAttendance
    {
        public StaffAttendanceRepo(ApplicationDbContext context) : base(context) { }
    }
}
