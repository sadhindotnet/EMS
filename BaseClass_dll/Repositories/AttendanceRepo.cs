using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface IAttendance : IBaseRepo<Attendance> { }


    public class AttendanceRepo : BaseRepo<Attendance>, IAttendance
    {
        public AttendanceRepo(ApplicationDbContext context) : base(context) { }
    }
}
