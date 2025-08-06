using BaseClass_dll.Infrastructure;
using BaseClass_dll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_dll.Repositories
{
    public interface INotification : IBaseRepo<Notification> { }

    public class NotificationRepo : BaseRepo<Notification>, INotification
    {
        public NotificationRepo(ApplicationDbContext context) : base(context) { }
    }
}
