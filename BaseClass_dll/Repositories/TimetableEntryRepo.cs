using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface ITimetableEntry : IBaseRepo<TimetableEntry> { }


    public class TimetableEntryRepo : BaseRepo<TimetableEntry>, ITimetableEntry
    {
        public TimetableEntryRepo(ApplicationDbContext context) : base(context) { }
    }
}
