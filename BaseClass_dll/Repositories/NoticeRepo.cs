using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface INotice : IBaseRepo<Notice> { }
    public class NoticeRepo : BaseRepo<Notice>, INotice
    {
        public NoticeRepo(ApplicationDbContext context) : base(context) { }
    }
}
